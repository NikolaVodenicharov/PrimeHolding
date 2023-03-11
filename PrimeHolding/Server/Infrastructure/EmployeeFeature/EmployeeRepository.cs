using Microsoft.EntityFrameworkCore;
using PrimeHolding.Server.Core.DepartmentFeature.Interfaces;
using PrimeHolding.Server.Core.EmployeeFeature.Entities;
using PrimeHolding.Server.Core.EmployeeFeature.Interfaces;
using PrimeHolding.Server.Core.EmployeeFeature.RequestModels;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;
using PrimeHolding.Server.Core.EmployeeFeature.Support;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;

namespace PrimeHolding.Server.Infrastructure.EmployeeFeature
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeManagementDbContext _dbContext;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeRepository(
            EmployeeManagementDbContext dbContext,
            IDepartmentRepository departmentRepository)
        {
            _dbContext = dbContext;
            _departmentRepository = departmentRepository;
        }

        public async Task<EmployeeResponse> CreateAsync(CreateEmployeeRequest createEmployeeRequest)
        {
            var employee = new Employee()
            {
                FullName = createEmployeeRequest.FullName,
                Email = createEmployeeRequest.Email,
                PhoneNumber = createEmployeeRequest.PhoneNumber,
                DateOfBirth = createEmployeeRequest.DateOfBirth,
                MonthlySalary = createEmployeeRequest.MonthlySalary,
                DepartmentId = createEmployeeRequest.DepartmentId
            };

            var result = await _dbContext.Employees.AddAsync(employee);

            await _dbContext.SaveChangesAsync();

            var departmentResponse = await _departmentRepository.GetAsync(createEmployeeRequest.DepartmentId);

            var employeeResponse = new EmployeeResponse(
                employee.Id,
                employee.FullName,
                employee.Email,
                employee.PhoneNumber,
                employee.DateOfBirth,
                employee.MonthlySalary,
                departmentResponse,
                new List<WorkTaskResponse>());

            return employeeResponse;
        }

        public async Task<EmployeeResponse?> GetAsync(Guid id)
        {
            var employeeResponse = await _dbContext
                .Employees
                .Where(e => e.Id == id)
                            .Include(e => e.Department)
                .Include(e => e.WorkTasks)
                .Select(e => e.ToEmployeeResponse())
                .FirstOrDefaultAsync();

            return employeeResponse;
        }

        public async Task<ICollection<EmployeeResponse>> GetAllAsync()
        {
            var employeeResponseCollection = await _dbContext
                .Employees
                .Include(e => e.Department)
                .Include(e => e.WorkTasks)
                .Select(e => e.ToEmployeeResponse())
                .ToListAsync();

            return employeeResponseCollection;
        }

        public async Task<EmployeeResponse> UpdateAsync(UpdateEmployeeRequest updateEmployeeRequest)
        {
            var employee = await _dbContext
                .Employees
                .FirstOrDefaultAsync(x => x.Id == updateEmployeeRequest.Id);

            if (employee == null)
            {
                return null;
            }

            employee.FullName = updateEmployeeRequest.FullName;
            employee.Email = updateEmployeeRequest.Email;
            employee.PhoneNumber = updateEmployeeRequest.PhoneNumber;
            employee.DateOfBirth = updateEmployeeRequest.DateOfBirth;
            employee.MonthlySalary = updateEmployeeRequest.MonthlySalary;
            employee.DepartmentId = updateEmployeeRequest.DepartmentId;

            _dbContext.Update(employee);

            await _dbContext.SaveChangesAsync();

            var employeeReponse = employee.ToEmployeeResponse();

            return employeeReponse;
        }

        public async Task<EmployeeResponse> DeleteAsync(Guid id)
        {
            var employee = await _dbContext
                .Employees
                .Include(e => e.WorkTasks)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null)
            {
                return null;
            }

            foreach (var workTask in employee.WorkTasks)
            {
                workTask.AssigneeId = Guid.Empty;
            }

            _dbContext.Employees.Remove(employee);

            await _dbContext.SaveChangesAsync();

            var employeeResponse = employee.ToEmployeeResponse();

            return employeeResponse;
        }

    }
}