namespace MortgagePaymentCalculator
{
    public sealed class Loan
    {
        public int Term { get; }
        public decimal Rate { get; }
        public int PaymentsPerYear { get; }
        public decimal Amount { get;}

        public decimal DownPayment { get; }
        public Loan(decimal amount, int term, decimal rate, int paymentsPerYear, decimal downPayment)
        {
            Amount = amount;
            Term = term;
            Rate = rate;
            PaymentsPerYear = paymentsPerYear;
            DownPayment = downPayment;
        }
    }
}
