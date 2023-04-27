namespace Project.Module.CreditHub.Domain.Loans.LoanTypes
{
    public class DirectLoan : Loan
    {
        public DirectLoan() 
        {
            Name = "DirectLoan";
            TaxRate = 0.02;
        }
    }
}