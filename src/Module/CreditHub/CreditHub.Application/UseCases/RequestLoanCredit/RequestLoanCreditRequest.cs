using MediatR;

namespace Project.Module.CreditHub.Application.UseCases.RequestLoanCredit
{
    public class RequestLoanCreditRequest : IRequest<RequestLoanCreditResponse>
    {
        public double Valor { get; private set; }
        public string TipoDeCredito { get; private set; }
        public int QuantidadeDeParcelas { get; private set; }
        public DateOnly DataDoPrimeiroVencimento { get; private set; }

        public RequestLoanCreditRequest(
            double valor,
            string tipoDeCredito,
            int quantidadeDeParcelas,
            string dataDoPrimeiroVencimento)
        {
            Valor = valor;
            TipoDeCredito = tipoDeCredito;
            QuantidadeDeParcelas = quantidadeDeParcelas;
            DataDoPrimeiroVencimento = DateOnly.Parse(dataDoPrimeiroVencimento);
        }
    }
}