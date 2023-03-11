namespace PrimeHolding.Client.Features.WorkTaskFeature.Models
{
    public record CreateWorkTaskRequest(
        string Title,
        string Description,
        DateTime DueDate,
        bool Completed,
        Guid AssigneeId);
}
