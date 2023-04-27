using Project.Module.CreditHub.Domain.Loans;
using Project.Module.CreditHub.Domain.Loans.LoanTypes;

namespace Project.Module.CreditHub.Domain.Helpers.Loans
{
    public class LoanFactory 
    {
        public  Loan CreateLoanBasedOnLoanCreditType(string loanCreditType)
        {
            switch (loanCreditType)
            {
                case "Crédito Direto":
                    return new DirectLoan();
                case "Crédito Consignado":
                    return  new PaydayLoan();
                case "Crédito Pessoa Jurídica":
                    return  new LegalLoan();
                case "Crédito Pessoa Física":
                    return  new NaturalPersonLoan();
                case "Crédito Imobiliário":
                    return  new HomeEquityLoan();
            }

            throw new Exception("Não existe implementação para o crédito solicitado a seguir: ${loanCreditType}");
        }
    }
}