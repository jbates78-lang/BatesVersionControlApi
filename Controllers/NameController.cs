
using Microsoft.AspNetCore.Mvc;

namespace BatesVersionControlApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new
            {
                Name = "Juan Bates"
            });
        }
    }
}
