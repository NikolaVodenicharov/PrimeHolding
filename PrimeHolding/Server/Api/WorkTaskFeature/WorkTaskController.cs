using Microsoft.AspNetCore.Mvc;
using PrimeHolding.Server.Core.EmployeeFeature.RequestModels;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;
using PrimeHolding.Server.Core.WorkTaskFeature.Interfaces;
using PrimeHolding.Server.Core.WorkTaskFeature.RequestModels;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;
using System.Net;

namespace PrimeHolding.Server.Api.WorkTaskFeature
{
    public class WorkTaskController : ApiControllerBase
    {
        private readonly IWorkTaskService _workTaskService;

        public WorkTaskController(IWorkTaskService workTaskService)
        {
            _workTaskService = workTaskService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(WorkTaskResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAsync(CreateWorkTaskRequest createWorkTaskRequest)
        {
            var workTaskResponse = await _workTaskService.CreateAsync(createWorkTaskRequest);

            return Ok(workTaskResponse);
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(WorkTaskResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var workTaskResponse = await _workTaskService.GetAsync(id);

            return Ok(workTaskResponse);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ICollection<WorkTaskResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllAsync()
        {
            var workTaskResponseCollection = await _workTaskService.GetAllAsync();

            return Ok(workTaskResponseCollection);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(WorkTaskResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateWorkTaskRequest updateWorkTaskRequest)
        {
            var workTaskResponse = await _workTaskService.UpdateAsync(updateWorkTaskRequest);

            return Ok(workTaskResponse);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _workTaskService.DeleteAsync(id);

            return Ok();
        }
    }
}
