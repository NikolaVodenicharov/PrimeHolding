namespace PrimeHolding.Server.Core.WorkTaskFeature.RequestModels
{
    public record CreateWorkTaskRequest(
        string Title,
        string Description,
        DateTime DueDate,
        bool Completed,
        Guid AssigneeId);
}
