using PrimeHolding.Server.Core.EmployeeFeature.Entities;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;

namespace PrimeHolding.Client.Features.DepartmentFeature.Models
{
    public record DepartmentResponse(
        Guid Id,
        string Name);
}
