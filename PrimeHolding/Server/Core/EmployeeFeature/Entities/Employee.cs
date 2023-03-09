using PrimeHolding.Server.Infrastructure.Entities;

namespace PrimeHolding.Server.Core.EmployeeFeature.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public decimal MonthlySalary { get; set; }

        public Guid DepartmentId { get; set; }

        public Department Department { get; set; } = default!;

        public ICollection<WorkTask> WorkTasks { get; set; } = new List<WorkTask>();
    }
}
