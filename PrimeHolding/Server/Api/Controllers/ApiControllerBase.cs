using Microsoft.AspNetCore.Mvc;

namespace PrimeHolding.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
    }
}
