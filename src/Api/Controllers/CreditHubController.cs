using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class CreditHubController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        public async Task<IActionResult> test()
        {
            return Ok();
        }
    }
}