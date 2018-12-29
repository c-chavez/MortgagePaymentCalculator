
namespace MortgagePaymentCalculator
{
    public sealed class AmortizationItem
    {
        public int MonthNro { get; set; }
        public decimal PaymentAmount => Principal + Interest;
        public decimal Interest { get; set; }

        public decimal Principal { get; set; }
        public decimal Balance { get; set; }
    }
}
