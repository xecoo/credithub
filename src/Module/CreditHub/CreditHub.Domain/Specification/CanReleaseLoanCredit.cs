namespace Project.Module.CreditHub.Domain.Specification
{
    public class CanReleaseLoanCredit
    {
        public double Value { get; set; }
        public string CreditType { get; set; }
        public int NumberOfINstallments { get; set; }
        public DateOnly FirstDueDate { get; set; }

        public CanReleaseLoanCredit(
            double value,
            string creditType,
            int numberOfINstallments,
            DateOnly firstDueDate)
        {
            Value = value;
            CreditType = creditType;
            NumberOfINstallments = numberOfINstallments;
            FirstDueDate = firstDueDate;
        }

        public bool IsSatisfied()
        {
            return true;
        }
    }
}