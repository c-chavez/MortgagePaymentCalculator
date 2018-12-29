
namespace MortgagePaymentCalculator
{
    public sealed class AmortizationItem
    {
        public int MonthNro { get; set; }
        public decimal PaymentAmount => Principal + Interest + Taxes + PMI + ExtraPayment;
        public decimal Interest { get; set; }
        public decimal Principal { get; set; }
        public decimal Balance { get; set; }
        public decimal PMI { get; set; }
        public decimal Taxes { get; set; }
        public decimal ExtraPayment { get; set; }
    }
}
