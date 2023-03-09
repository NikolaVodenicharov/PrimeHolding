using PrimeHolding.Server.Core.WorkTaskFeature.RequestModels;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;

namespace PrimeHolding.Server.Core.WorkTaskFeature.Interfaces
{
    public interface IWorkTaskService
    {
        Task<WorkTaskResponse> CreateAsync(CreateWorkTaskRequest createWorkTaskRequest);

        Task<WorkTaskResponse> GetAsync(Guid id);

        Task<ICollection<WorkTaskResponse>> GetAllAsync();

        Task<WorkTaskResponse> UpdateAsync(UpdateWorkTaskRequest updateWorkTaskRequest);

        Task DeleteAsync(Guid id);
    }
}
