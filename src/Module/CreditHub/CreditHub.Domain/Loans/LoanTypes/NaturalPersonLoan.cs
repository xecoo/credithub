namespace Project.Module.CreditHub.Domain.Loans.LoanTypes
{
    public class NaturalPersonLoan : Loan
    {
        public NaturalPersonLoan()
        {
            Name = "NaturalPersonLoan";
            TaxRate = 0.03;
        }
    }
}