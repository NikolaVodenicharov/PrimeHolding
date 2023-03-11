using Microsoft.AspNetCore.Mvc;

namespace PrimeHolding.Server.Api;

[Route("api/[controller]")]
[ApiController]
public abstract class ApiControllerBase : ControllerBase
{
}
