using PrimeHolding.Server.Core.EmployeeFeature.Entities;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;

namespace PrimeHolding.Server.Core.DepartmentFeature.ResponseModels
{
    public record DepartmentResponse(
        Guid Id,
        string Name);
}
