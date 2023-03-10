using PrimeHolding.Server.Core.WorkTaskFeature.Entities;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;

namespace PrimeHolding.Server.Core.WorkTaskFeature.Support
{
    public static class WorkTaskMappingExtensions
    {
        public static WorkTaskResponse ToWorkTaskResponse(this WorkTask workTask)
        {
            var workTaskResponse = new WorkTaskResponse(
                workTask.Id,
                workTask.Title,
                workTask.Description,
                workTask.DueDate,
                workTask.Completed,
                workTask.AssigneeId);

            return workTaskResponse;
        }
    }
}
