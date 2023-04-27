namespace Project.Module.CreditHub.Domain.Loans.LoanTypes
{
    public class HomeEquityLoan : Loan
    {
        public HomeEquityLoan()
        {
            Name = "HomeEquityLoan";
            TaxRate = 0.09;
        }
    }
}