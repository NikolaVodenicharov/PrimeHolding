using PrimeHolding.Server.Core.WorkTaskFeature.Interfaces;
using PrimeHolding.Server.Core.WorkTaskFeature.RequestModels;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;

namespace PrimeHolding.Server.Core.WorkTaskFeature
{
    public class WorkTaskService : IWorkTaskRepository
    {
        private readonly IWorkTaskRepository _workTaskRepository;

        public WorkTaskService(IWorkTaskRepository workTaskRepository)
        {
            _workTaskRepository = workTaskRepository;
        }

        public async Task<WorkTaskResponse> CreateAsync(CreateWorkTaskRequest createWorkTaskRequest)
        {
            var workTaskResponse = await _workTaskRepository.CreateAsync(createWorkTaskRequest);

            return workTaskResponse;
        }

        public async Task<WorkTaskResponse> GetAsync(Guid id)
        {
            var workTaskResponse = await _workTaskRepository.GetAsync(id);

            return workTaskResponse;
        }

        public async Task<ICollection<WorkTaskResponse>> GetAllAsync()
        {
            var workTaskResponseCollection = await _workTaskRepository.GetAllAsync();

            return workTaskResponseCollection;
        }

        public async Task<WorkTaskResponse> UpdateAsync(UpdateWorkTaskRequest updateWorkTaskRequest)
        {
            var workTaskResponse = await _workTaskRepository.UpdateAsync(updateWorkTaskRequest);

            return workTaskResponse;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _workTaskRepository.DeleteAsync(id);
        }
    }
}
