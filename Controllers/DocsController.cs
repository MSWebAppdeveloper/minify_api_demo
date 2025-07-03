using Microsoft.AspNetCore.Mvc;

namespace EzzyBillApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocsController : Controller
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok(new { message = "API is working 🚀" });
        }
    }
}
