using Project.Module.CreditHub.Domain.Loans;
using Project.Module.CreditHub.Domain.Loans.LoanTypes;

namespace Project.Module.CreditHub.Domain.Specification
{
    public class CanReleaseLoanCredit
    {
        public double Value { get; set; }
        public string LoanCreditType { get; set; }
        public int NumberOfInstallments { get; set; }
        public DateOnly FirstDueDate { get; set; }

        public CanReleaseLoanCredit(
            double value,
            string creditType,
            int numberOfInstallments,
            DateOnly firstDueDate)
        {
            Value = value;
            LoanCreditType = creditType;
            NumberOfInstallments = numberOfInstallments;
            FirstDueDate = firstDueDate;
        }

        public bool IsSatisfied()
        {
            var loan = CreateLoanBasedOnLoanCreditType(LoanCreditType);

            if(!(Value <= 1000000.00))
                return false;

            if(NumberOfInstallments >= 5 && NumberOfInstallments <= 75)
                return false;

            if(!(FirstDueDate >= DateOnly.FromDateTime(DateTime.UtcNow.AddDays(15))) && (FirstDueDate >= DateOnly.FromDateTime(DateTime.UtcNow.AddDays(40))))
                return false; 
            
            if(loan.GetName() == "LegalLoan")
                return Value >= 15000.00;

            return true;
        }

        private Loan CreateLoanBasedOnLoanCreditType(string loanCreditType)
        {
            switch (loanCreditType)
            {
                case "Crédito Direto":
                    return new PaydayLoan();
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