namespace PrimeHolding.Server.Core.WorkTaskFeature.RequestModels
{
    public record UpdateWorkTaskRequest(
        Guid Id,
        string Title,
        string Description,
        DateTime DueDate,
        bool Completed,
        Guid AssigneeId);
}
