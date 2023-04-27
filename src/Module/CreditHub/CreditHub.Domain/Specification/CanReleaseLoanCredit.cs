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

        public bool IsSatisfied(string loanTypeName)
        {
            if(!(Value <= 1000000.00))
                return false;

            if(!(NumberOfInstallments >= 5) || !(NumberOfInstallments <= 75))
                return false;

            if(!(FirstDueDate >= DateOnly.FromDateTime(DateTime.UtcNow.AddDays(15))) || !(FirstDueDate <= DateOnly.FromDateTime(DateTime.UtcNow.AddDays(40))))
                return false; 
            
            if(loanTypeName == "LegalLoan")
                return Value >= 15000.00;

            return true;
        }
    }
}