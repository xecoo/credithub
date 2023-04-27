using MediatR;

namespace Project.Module.CreditHub.Application.UseCases.RequestLoanCredit
{
    public class RequestLoanCreditHandler : IRequestHandler<RequestLoanCreditRequest, RequestLoanCreditResponse>
    {
        public async Task<RequestLoanCreditResponse> Handle(
            RequestLoanCreditRequest request, 
            CancellationToken cancellationToken)
        {
            return new RequestLoanCreditResponse(1,"",1,1);
        }
    }
}