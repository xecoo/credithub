namespace Project.Module.CreditHub.Domain.Loan.LoanTypes
{
    public class HomeEquityLoan : Loan
    {
        public HomeEquityLoan(
            string name,
            double taxRate) : base(name, taxRate)
        {
            Name = "HomeEquityLoan";
            TaxRate = 0.03;
        }
    }
}