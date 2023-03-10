using PrimeHolding.Server.Core.DepartmentFeature.ResponseModels;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;

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
