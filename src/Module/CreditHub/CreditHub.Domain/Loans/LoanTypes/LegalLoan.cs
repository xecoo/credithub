namespace Project.Module.CreditHub.Domain.Loans.LoanTypes
{
    public class LegalLoan : Loan
    {
        public LegalLoan()
        {
            Name = "LegalLoan";
            TaxRate = 0.05;
        }
    }
}