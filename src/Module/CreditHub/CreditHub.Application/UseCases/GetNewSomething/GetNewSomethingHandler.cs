using MediatR;

namespace Project.Module.CreditHub.Application.UseCases.GetNewSomething
{
    public class GetNewSomethingHandler : IRequestHandler<GetNewSomethingRequest, GetNewSomethingResponse>
    {
        public async Task<GetNewSomethingResponse> Handle(
            GetNewSomethingRequest request, 
            CancellationToken cancellationToken)
        {
            return new GetNewSomethingResponse
            {
                Number = request.Number + 1
            };
        }
    }
}