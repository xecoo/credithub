namespace Project.Module.CreditHub.Domain.Loans
{
    public class Loan
    {
        protected string Name { get; set; }
        protected double TaxRate { get; set; }

        public Loan() { }

        public Loan(string name, double taxRate)
        {
            Name = name;
            TaxRate = taxRate;
        }

        public double CreateValueToBePaid(double requestValue) => requestValue * (1 + TaxRate);
        public string GetName() => Name;
    }
}