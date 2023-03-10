using PrimeHolding.Server.Core.DepartmentFeature.Interfaces;
using PrimeHolding.Server.Core.DepartmentFeature.RequestModels;
using PrimeHolding.Server.Core.DepartmentFeature.ResponseModels;

namespace PrimeHolding.Server.Core.DepartmentFeature
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<DepartmentResponse> CreateAsync(CreateDepartmentRequest createDepartmentRequest)
        {
            var departmentResponse = await _departmentRepository.CreateAsync(createDepartmentRequest);

            return departmentResponse;
        }
    }
}
