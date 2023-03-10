using PrimeHolding.Server.Core.DepartmentFeature.RequestModels;
using PrimeHolding.Server.Core.DepartmentFeature.ResponseModels;

namespace PrimeHolding.Server.Core.DepartmentFeature.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<DepartmentResponse> CreateAsync(CreateDepartmentRequest createDepartmentRequest);
        Task<DepartmentResponse?> GetAsync(Guid id);
    }
}
