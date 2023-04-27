using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Ap.Controllers.Resources;
using Project.Module.CreditHub.Application.UseCases.RequestLoanCredit;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreditHubController : ControllerBase
    {
        [HttpGet]
        [Route("LiberarCredito")]
        public async Task<IActionResult> RequestLoanCredit(
            [FromBody] RequestLoanCreditDto requestLoanCreditDto,
            [FromServices] IMediator mediator)
        {
            var request = new RequestLoanCreditRequest(
                requestLoanCreditDto.Valor,
                requestLoanCreditDto.TipoDeCredito,
                requestLoanCreditDto.QuantidadeDeParcelas,
                requestLoanCreditDto.DataDoPrimeiroVencimento);

            var response =  await mediator.Send(request);

            var responseLoanCreditDto = new ResponseLoanCreditDto(
                response.StatusAsString,
                response.DebitoTotal,
                response.ValorDoJuros);

            return Ok(responseLoanCreditDto);
        }
    }
}