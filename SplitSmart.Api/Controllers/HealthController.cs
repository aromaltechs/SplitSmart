using Microsoft.AspNetCore.Mvc;

namespace SplitSmart.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { status = "SplitSmart API is running" });
        }
    }
}