using PrimeHolding.Server.Core.DepartmentFeature.RequestModels;
using PrimeHolding.Server.Core.DepartmentFeature.ResponseModels;

namespace PrimeHolding.Server.Core.DepartmentFeature.Interfaces
{
    public interface IDepartmentService
    {
        Task<DepartmentResponse> CreateAsync(CreateDepartmentRequest createDepartmentRequest);
    }
}
