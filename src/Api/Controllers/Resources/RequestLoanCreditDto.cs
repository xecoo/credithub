namespace Project.Ap.Controllers.Resources
{
    public class RequestLoanCreditDto
    {
        public double Valor { get; set; }
        public string TipoDeCredito { get; set; }
        public int QuantidadeDeParcelas { get; set; }
        public DateOnly DataDoPrimeiroVencimento { get; set; } 
    }
}