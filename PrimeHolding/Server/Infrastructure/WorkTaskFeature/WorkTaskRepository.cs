using Microsoft.EntityFrameworkCore;
using PrimeHolding.Server.Core.WorkTaskFeature.Entities;
using PrimeHolding.Server.Core.WorkTaskFeature.Interfaces;
using PrimeHolding.Server.Core.WorkTaskFeature.RequestModels;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;
using PrimeHolding.Server.Core.WorkTaskFeature.Support;

namespace PrimeHolding.Server.Infrastructure.WorkTaskFeature
{
    public class WorkTaskRepository : IWorkTaskRepository
    {
        private readonly EmployeeManagementDbContext _dbContext;

        public WorkTaskRepository(EmployeeManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WorkTaskResponse> CreateAsync(CreateWorkTaskRequest createWorkTaskRequest)
        {
            var workTask = new WorkTask()
            {
                Title = createWorkTaskRequest.Title,
                Description = createWorkTaskRequest.Description,
                DueDate = createWorkTaskRequest.DueDate,
                Completed = createWorkTaskRequest.Completed,
                AssigneeId = createWorkTaskRequest.AssigneeId
            };

            await _dbContext.WorkTasks.AddAsync(workTask);

            await _dbContext.SaveChangesAsync();

            var workTaskResponse = workTask.ToWorkTaskResponse();

            return workTaskResponse;
        }

        public async Task<WorkTaskResponse?> GetAsync(Guid id)
        {
            var workTaskResponse = await _dbContext
                .WorkTasks
                .Where(wt => wt.Id == id)
                .Select(wt => wt.ToWorkTaskResponse())
                .FirstOrDefaultAsync();

            return workTaskResponse;
        }

        public async Task<ICollection<WorkTaskResponse>> GetAllAsync()
        {
            var workTaskResponseCollection = await _dbContext
                .WorkTasks
                .Select(wt => wt.ToWorkTaskResponse())
                .ToListAsync();

            return workTaskResponseCollection;
        }

        public async Task<WorkTaskResponse> UpdateAsync(UpdateWorkTaskRequest updateWorkTaskRequest)
        {
            var workTask = await _dbContext.WorkTasks.FirstOrDefaultAsync(x => x.Id == updateWorkTaskRequest.Id);

            if (workTask == null)
            {
                return null;
            }

            workTask.Title = updateWorkTaskRequest.Title;
            workTask.Description = updateWorkTaskRequest.Description;
            workTask.DueDate = updateWorkTaskRequest.DueDate;
            workTask.Completed = updateWorkTaskRequest.Completed;
            workTask.AssigneeId = updateWorkTaskRequest.AssigneeId;

            _dbContext.Update(workTask);

            await _dbContext.SaveChangesAsync();

            var workTaskReponse = workTask.ToWorkTaskResponse();

            return workTaskReponse;
        }

        public async Task DeleteAsync(Guid id)
        {
            var workTask = await _dbContext.WorkTasks.FirstOrDefaultAsync(wt => wt.Id == id);

            if (workTask == null)
            {
                return;
            }

            _dbContext.WorkTasks.Remove(workTask);

            await _dbContext.SaveChangesAsync();
        }
    }
}
