namespace Project.Module.CreditHub.Domain.Loan.LoanTypes
{
    public class NaturalPersonLoan : Loan
    {
        public NaturalPersonLoan(
            string name,
            double taxRate) : base(name, taxRate)
        {
            Name = "NaturalPersonLoan";
            TaxRate = 0.03;
        }
    }
}