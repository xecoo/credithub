namespace Project.Module.CreditHub.Domain.Loans.LoanTypes
{
    public class PaydayLoan : Loan
    {
        public PaydayLoan()
        {
            Name = "PaydayLoan";
            TaxRate = 0.01;
        }
    }
}