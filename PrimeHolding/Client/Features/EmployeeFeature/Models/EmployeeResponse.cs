using PrimeHolding.Client.Features.DepartmentFeature.Models;
using PrimeHolding.Client.Features.WorkTaskFeature.Models;

namespace PrimeHolding.Server.Core.EmployeeFeature.ResponseModels
{
    public record EmployeeResponse(
        Guid Id,
        string FullName,
        string Email,
        string PhoneNumber,
        DateTime DateOfBirth,
        decimal MonthlySalary,
        DepartmentResponse DepartmentResponse,
        ICollection<WorkTaskResponse> Tasks);
}
