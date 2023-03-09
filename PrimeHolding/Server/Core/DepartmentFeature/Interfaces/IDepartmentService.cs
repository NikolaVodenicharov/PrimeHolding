using PrimeHolding.Server.Core.DepartmentFeature.RequestModels;

namespace PrimeHolding.Server.Core.DepartmentFeature.Interfaces
{
    public interface IDepartmentService
    {
        Task CreateAsync(CreateDepartmentRequest createDepartmentRequest);
    }
}
