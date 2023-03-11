using Microsoft.AspNetCore.Mvc;
using PrimeHolding.Server.Core.DepartmentFeature.Interfaces;
using PrimeHolding.Server.Core.DepartmentFeature.RequestModels;
using PrimeHolding.Server.Core.DepartmentFeature.ResponseModels;
using System.Net;

namespace PrimeHolding.Server.Api.DepartmentFeature
{
    public class DepartmentsController : ApiControllerBase
    {
        private readonly IDepartmentService _departmentsService;

        public DepartmentsController(IDepartmentService departmentsService)
        {
            _departmentsService = departmentsService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(DepartmentResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAsync(CreateDepartmentRequest createDepartmentRequest)
        {
            var departmentResponse = await _departmentsService.CreateAsync(createDepartmentRequest);

            return Ok(departmentResponse);
        }
    }
}
