namespace Project.Module.CreditHub.Application.UseCases.RequestLoanCredit
{
    public class RequestLoanCreditResponse 
    {
        public int Status { get; private set; }
        public string StatusAsString { get; private set; }
        public double DebitoTotal { get; private set; }
        public double ValorDoJuros { get; private set; }


        public RequestLoanCreditResponse(
            int status,
            string statusAsString)
        {
            Status = status;
            StatusAsString = statusAsString;
        }

        public RequestLoanCreditResponse(
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