using Microsoft.AspNetCore.Mvc;

namespace DotNet8WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[] {
            new { Id=1, City="Pune", Temperature=30 },
            new { Id=2, City="Mumbai", Temperature=32 }
        });
    }
}