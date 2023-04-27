namespace Project.Module.CreditHub.Application.UseCases.GetNewSomething
{
    public class GetNewSomethingResponse 
    {
        public int Status { get; private set; }
        public string StatusAsString { get; private set; }
        public double DebitoTotal { get; private set; }
        public double ValorDoJuros { get; private set; }

        public GetNewSomethingResponse(
            int status,
            string statusAsString,
            double debitoTotal,
            double valorDoJuros)
        {
            Status = status;
            StatusAsString = statusAsString;
            DebitoTotal = debitoTotal;
            ValorDoJuros = valorDoJuros;
        }
    }
}