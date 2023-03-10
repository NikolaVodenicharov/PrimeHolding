using PrimeHolding.Server.Core.EmployeeFeature.RequestModels;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;

namespace PrimeHolding.Server.Core.EmployeeFeature.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<EmployeeResponse> CreateAsync(CreateEmployeeRequest createEmployeeRequest);

        Task<EmployeeResponse?> GetAsync(Guid id);

        Task<ICollection<EmployeeResponse>> GetAllAsync();

        Task<EmployeeResponse> UpdateAsync(UpdateEmployeeRequest updateEmployeeRequest);

        Task<EmployeeResponse> DeleteAsync(Guid id);
    }
}
