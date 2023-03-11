using PrimeHolding.Client.Features.EmployeeFeature.Components;
using PrimeHolding.Server.Core.EmployeeFeature.ResponseModels;
using System.Net;
using System.Net.Http.Json;

namespace PrimeHolding.Client.Features.EmployeeFeature.Services
{
    public class EmployeeService : IEmployeeService
    {
        private const string EmployeesControllerUrl = "employees";
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<EmployeeResponse>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync($"{EmployeesControllerUrl}");

            if(!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return new List<EmployeeResponse>();
            }

            var employees = await response.Content.ReadFromJsonAsync<ICollection<EmployeeResponse>>();

            return employees;
        }
    }
}
