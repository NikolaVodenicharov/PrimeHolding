namespace PrimeHolding.Server.Infrastructure.Entities
{
    public class WorkTask
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime DueDate { get; set; }

        public bool Completed { get; set; }

        public Guid AssigneeId { get; set; }

        public Employee Assignee { get; set; } = default!;
    }
}
