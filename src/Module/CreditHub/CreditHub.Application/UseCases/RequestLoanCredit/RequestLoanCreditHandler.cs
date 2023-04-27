using MediatR;
using Project.Module.CreditHub.Domain.Specification;

namespace Project.Module.CreditHub.Application.UseCases.RequestLoanCredit
{
    public class RequestLoanCreditHandler : IRequestHandler<RequestLoanCreditRequest, RequestLoanCreditResponse>
    {
        public async Task<RequestLoanCreditResponse> Handle(
            RequestLoanCreditRequest request, 
            CancellationToken cancellationToken)
        {
            var loanCredit = new CanReleaseLoanCredit(
                request.Valor,
                request.TipoDeCredito,
                request.QuantidadeDeParcelas,
                request.DataDoPrimeiroVencimento);

            if(!loanCredit.IsSatisfied())
                return new RequestLoanCreditResponse(1, "Reprovado");

            // return new RequestLoanCreditResponse(loanCredit);
            throw new NotImplementedException();
        }
    }
}