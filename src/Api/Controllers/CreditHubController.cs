using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Module.CreditHub.Application.UseCases.GetNewSomething;

namespace Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class CreditHubController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        public async Task<IActionResult> test(
            [FromBody] Dto dto,
            [FromServices] IMediator mediator
        )
        {
            var request = new GetNewSomethingRequest(dto.Number);

            var responde =  await mediator.Send(request);

            return Ok(responde);
        }
    }

    public class Dto
    {
        public int Number { get; set; }
    }
}