namespace PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels
{
    public record WorkTaskResponse(
        Guid Id,
        string Title,
        string Description,
        DateTime DueDate,
        bool Completed,
        Guid AssigneeId);
}
