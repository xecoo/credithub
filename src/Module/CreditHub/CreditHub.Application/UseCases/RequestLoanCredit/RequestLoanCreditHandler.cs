using MediatR;

namespace Project.Module.CreditHub.Application.UseCases.RequestLoanCredit
{
    public class RequestLoanCreditHandler : IRequestHandler<RequestLoanCreditRequest, RequestLoanCreditResponse>
    {
        public async Task<RequestLoanCreditResponse> Handle(
            RequestLoanCreditRequest request, 
            CancellationToken cancellationToken)
        {
            // var loanCredit = CanReleaseLoanCredit.IsSatisfiedBasedOn();

            // return new RequestLoanCreditResponse(loanCredit);
            throw new NotImplementedException();
        }
    }
}