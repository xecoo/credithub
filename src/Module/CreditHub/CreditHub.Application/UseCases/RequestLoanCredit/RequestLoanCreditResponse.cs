namespace Project.Module.CreditHub.Application.UseCases.RequestLoanCredit
{
    public class RequestLoanCreditResponse 
    {
        public string StatusAsString { get; private set; }
        public double DebitoTotal { get; private set; }
        public double ValorDoJuros { get; private set; }

        public RequestLoanCreditResponse(string status) 
        {
            StatusAsString = status;
        }

        public RequestLoanCreditResponse(
            string statusAsString,
            double debitoTotal,
            double valorDoJuros)
        {
            StatusAsString = statusAsString;
            DebitoTotal = debitoTotal;
            ValorDoJuros = valorDoJuros;
        }
    }
}