using MediatR;
using Project.Module.CreditHub.Domain.Helpers.Loans;
using Project.Module.CreditHub.Domain.Loans;
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

            var loan = new LoanFactory().CreateLoanBasedOnLoanCreditType(request.TipoDeCredito);

            if(!loanCredit.IsSatisfied(loan.GetName()))
                return new RequestLoanCreditResponse("Reprovado");

            return CreateResponseBasedOnResult(loan, loanCredit.Value, "Aprovado");
        }

    private RequestLoanCreditResponse CreateResponseBasedOnResult(
        Loan loan,
        double loanCreditValue, 
        string result)
    {
        if(result == "Aprovado")
            return new RequestLoanCreditResponse(
                "Aprovado",
                loan.CreateValueToBePaid(loanCreditValue),
                loan.GetTaxRate()); 

        return new RequestLoanCreditResponse("Reprovado");
    }
    }
}