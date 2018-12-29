namespace MortgagePaymentCalculator
{
    public sealed class Loan
    {
        public int Term { get; }
        public decimal Rate { get; }
        public int PaymentsPerYear { get; }
        public decimal Amount { get;}
        public decimal DownPayment { get; }
        public decimal PropertyTaxes { get; }
        public decimal PMI { get; }
        public decimal ExtraPayment { get; }
        public Loan(decimal amount, int term, decimal rate, int paymentsPerYear, decimal downPayment,
            decimal propertyTaxes, decimal pmi, decimal extraPayment)
        {
            Amount = amount;
            Term = term;
            Rate = rate;
            PaymentsPerYear = paymentsPerYear;
            DownPayment = downPayment;
            PropertyTaxes = propertyTaxes;
            PMI = pmi;
            ExtraPayment = extraPayment;
        }
    }
}
