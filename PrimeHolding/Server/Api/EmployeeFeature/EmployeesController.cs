using Microsoft.AspNetCore.Mvc;
using PrimeHolding.Server.Core.EmployeeFeature.Interfaces;
using PrimeHolding.Server.Core.EmployeeFeature.RequestModels;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;
using System.Net;

namespace PrimeHolding.Server.Api.EmployeeFeature
{
    public class EmployeesController : ApiControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(EmployeeResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAsync(CreateEmployeeRequest createEmployeeRequest)
        {
            var employeeResponse = await _employeeService.CreateAsync(createEmployeeRequest);

            return Ok(employeeResponse);
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(EmployeeResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var employeeResponse = await _employeeService.GetAsync(id);

            return Ok(employeeResponse);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ICollection<EmployeeResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllAsync()
        {
            var employeeResponseCollection = await _employeeService.GetAllAsync();

            return Ok(employeeResponseCollection);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(EmployeeResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateEmployeeRequest updateEmployeeRequest)
        {
            var employeeResponse = await _employeeService.UpdateAsync(updateEmployeeRequest);

            return Ok(employeeResponse);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _employeeService.DeleteAsync(id);

            return Ok();
        }
    }
}
