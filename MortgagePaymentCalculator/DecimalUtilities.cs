using System;

namespace MortgagePaymentCalculator
{
    public static class DecimalUtils
    {
        public static decimal RoundDecimalUp(decimal number)
        {
            return number == 0.0m ? number : decimal.Round(RoundDecimal(number, 0.01M),2);
        }

        public static decimal Pow(decimal x, decimal y)
        {
            double m = Math.Pow((double)x, (double)y);
            return (decimal)m;
        }

        private static decimal RoundDecimal(decimal decimalToRoundUp, decimal multiple)
        {
            decimal multipleOf = Math.Round(Math.Abs(multiple), 6, MidpointRounding.AwayFromZero);
            decimal remainder = Decimal.Remainder(decimalToRoundUp, multipleOf);
            return  decimalToRoundUp + multipleOf - remainder;
           
        }
    }
}
