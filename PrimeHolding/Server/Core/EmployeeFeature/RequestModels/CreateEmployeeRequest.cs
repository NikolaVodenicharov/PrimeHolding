namespace PrimeHolding.Server.Core.EmployeeFeature.RequestModels
{
    public record CreateEmployeeRequest(
        string FullName,
        string Email,
        string PhoneNumber,
        DateTime DateOfBirth,
        decimal MonthlySalary,
        Guid DepartmentId);
}
