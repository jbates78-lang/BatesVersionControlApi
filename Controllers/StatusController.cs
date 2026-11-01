using Microsoft.AspNetCore.Mvc;

namespace BatesVersionControlApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult GetStatus()
    {
        return Ok(new { Status = "API is running" });
    }
}
