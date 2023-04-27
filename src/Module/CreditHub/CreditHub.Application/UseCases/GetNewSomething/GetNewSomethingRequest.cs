using MediatR;

namespace Project.Module.CreditHub.Application.UseCases.GetNewSomething
{
    public class GetNewSomethingRequest : IRequest<GetNewSomethingResponse>
    {
        public int Number { get; set; }

        public GetNewSomethingRequest(int number)
        {
            Number = number;
        }
    }
}