namespace PrimeHolding.Server.Core.EmployeeFeature.RequestModels
{
    public record UpdateEmployeeRequest(
        Guid Id,
        string FullName,
        string Email,
        string PhoneNumber,
        DateTime DateOfBirth,
        decimal MonthlySalary,
        Guid DepartmentId,
        ICollection<Guid> TaskIds);
}
