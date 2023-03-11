namespace PrimeHolding.Client.Features.EmployeeFeature.Models
{
    public record CreateEmployeeRequest(
        string FullName,
        string Email,
        string PhoneNumber,
        DateTime DateOfBirth,
        decimal MonthlySalary,
        Guid DepartmentId);
}
