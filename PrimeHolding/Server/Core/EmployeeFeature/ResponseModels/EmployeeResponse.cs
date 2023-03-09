using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;
using PrimeHolding.Shared.Models.WorkTaskModels;

namespace PrimeHolding.Server.Core.EmployeeFeature.ResponseModels
{
    public record EmployeeResponse(
        Guid Id,
        string FullName,
        string Email,
        string PhoneNumber,
        DateTime DateOfBirth,
        decimal MonthlySalary,
        Guid DepartmentId,
        ICollection<WorkTaskResponse> Tasks);
}
