using PrimeHolding.Server.Core.DepartmentFeature.Entities;
using PrimeHolding.Server.Core.DepartmentFeature.ResponseModels;

namespace PrimeHolding.Server.Core.DepartmentFeature.Support
{
    public static class DepartmentMappingExtensions
    {
        public static DepartmentResponse ToDepartmentResponse(this Department department)
        {
            var departmentResponse = new DepartmentResponse(
                department.Id,
                department.Name);

            return departmentResponse;
        }
    }
}
