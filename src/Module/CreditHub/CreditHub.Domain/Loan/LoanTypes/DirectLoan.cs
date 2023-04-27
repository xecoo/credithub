namespace Project.Module.CreditHub.Domain.Loan.LoanTypes
{
    public class DirectLoan : Loan
    {
        public DirectLoan(
            string name,
            double taxRate) : base(name, taxRate)
        {
            Name = "DirectLoan";
            TaxRate = 0.02;
        }
    }
}