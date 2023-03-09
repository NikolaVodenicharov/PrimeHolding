using PrimeHolding.Server.Core.DepartmentFeature.RequestModels;

namespace PrimeHolding.Server.Core.DepartmentFeature.Interfaces
{
    public interface IDepartmentRepository
    {
        Task CreateAsync(CreateDepartmentRequest createDepartmentRequest);
    }
}
