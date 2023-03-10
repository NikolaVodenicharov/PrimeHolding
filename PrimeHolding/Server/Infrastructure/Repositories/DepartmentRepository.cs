using Microsoft.EntityFrameworkCore;
using PrimeHolding.Server.Core.DepartmentFeature.Entities;
using PrimeHolding.Server.Core.DepartmentFeature.Interfaces;
using PrimeHolding.Server.Core.DepartmentFeature.RequestModels;
using PrimeHolding.Server.Core.DepartmentFeature.ResponseModels;
using PrimeHolding.Server.Core.DepartmentFeature.Support;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;

namespace PrimeHolding.Server.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeManagementDbContext _dbContext;

        public DepartmentRepository(EmployeeManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DepartmentResponse> CreateAsync(CreateDepartmentRequest createDepartmentRequest)
        {
            var department = new Department()
            {
                Name = createDepartmentRequest.Name
            };

            var result = await _dbContext.Departments.AddAsync(department);

            await _dbContext.SaveChangesAsync();

            var departmentResponse = new DepartmentResponse(department.Id, department.Name);

            return departmentResponse;
        }

        public async Task<DepartmentResponse?> GetAsync(Guid id)
        {
            var departmentResponse = await _dbContext
                .Departments
                .Where(d => d.Id == id)
                .Select(d => d.ToDepartmentResponse())
                .FirstOrDefaultAsync();

            return departmentResponse;
        }
    }
}
