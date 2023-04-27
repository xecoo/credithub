namespace Project.Ap.Controllers.Resources
{
    public class ResponseLoanCreditDto 
    {
        public string StatusAsString { get; set; }
        public double DebitoTotal { get; set; }
        public double ValorDoJuros { get; set; }

        public ResponseLoanCreditDto(
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