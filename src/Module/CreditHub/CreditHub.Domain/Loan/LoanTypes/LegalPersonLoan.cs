namespace Project.Module.CreditHub.Domain.Loan.LoanTypes
{
    public class LegalPersonLoan : Loan
    {
        public LegalPersonLoan(
            string name,
            double taxRate) : base(name, taxRate)
        {
            Name = "LegalPersonLoan";
            TaxRate = 0.05;
        }
    }
}