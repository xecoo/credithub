namespace Project.Module.CreditHub.Domain.Loan.LoanTypes
{
    public class PaydayLoan : Loan
    {
        public PaydayLoan(
            string name,
            double taxRate) : base(name, taxRate)
        {
            Name = "PaydayLoan";
            TaxRate = 0.01;
        }
    }
}