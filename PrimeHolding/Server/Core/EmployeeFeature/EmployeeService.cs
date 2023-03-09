using PrimeHolding.Server.Core.EmployeeFeature.Interfaces;
using PrimeHolding.Server.Core.EmployeeFeature.RequestModels;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;

namespace PrimeHolding.Server.Core.EmployeeFeature
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResponse> CreateAsync(CreateEmployeeRequest createEmployeeRequest)
        {
            var employeeResponse = await _employeeRepository.CreateAsync(createEmployeeRequest);

            return employeeResponse;
        }

        public async Task<EmployeeResponse> GetAsync(Guid id)
        {
            var employeeResponse = await _employeeRepository.GetAsync(id);

            return employeeResponse;
        }

        public async Task<ICollection<EmployeeResponse>> GetAllAsync()
        {
            var employeeResponseCollection = await _employeeRepository.GetAllAsync();

            return employeeResponseCollection;
        }

        public async Task<EmployeeResponse> UpdateAsync(UpdateEmployeeRequest updateEmployeeRequest)
        {
            var employeeResponse = await _employeeRepository.UpdateAsync(updateEmployeeRequest);

            return employeeResponse;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _employeeRepository.DeleteAsync(id);
        }
    }
}
