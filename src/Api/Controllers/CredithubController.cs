using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class CreditHubController : ControllerBase
    {
        [HttpPost("test")]
        public async Task<IActionResult> Test()
        {
            return Ok();
        }
    }
}