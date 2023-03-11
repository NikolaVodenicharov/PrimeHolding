namespace PrimeHolding.Client.Features.WorkTaskFeature.Models
{
    public record WorkTaskResponse(
        Guid Id,
        string Title,
        string Description,
        DateTime DueDate,
        bool Completed,
        Guid AssigneeId);
}
