using PrimeHolding.Server.Core.DepartmentFeature.Support;
using PrimeHolding.Server.Core.EmployeeFeature.Entities;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;
using PrimeHolding.Server.Core.WorkTaskFeature.ResponseModels;
using PrimeHolding.Server.Core.WorkTaskFeature.Support;

namespace PrimeHolding.Server.Core.EmployeeFeature.Support
{
    public static class EmployeeMappingExtensions
    {
        public static EmployeeResponse ToEmployeeResponse(this Employee employee)
        {
            var workTaskResponseCollection = new List<WorkTaskResponse>();

            foreach (var workTask in employee.WorkTasks)
            {
                workTaskResponseCollection.Add(workTask.ToWorkTaskResponse());
            };

            var employeeResponse = new EmployeeResponse(
                employee.Id,
                employee.FullName,
                employee.Email,
                employee.PhoneNumber,
                employee.DateOfBirth,
                employee.MonthlySalary,
                employee.Department.ToDepartmentResponse(),
                workTaskResponseCollection);

            return employeeResponse;
        }
    }
}
