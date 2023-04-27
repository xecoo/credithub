namespace Project.Module.CreditHub.Domain.Loan
{
    public class Loan
    {
        protected string Name { get; set; }
        protected double TaxRate { get; set;}

        public Loan(string name, double taxRate)
        {
            Name = name;
            TaxRate = taxRate;
        }
    }
}