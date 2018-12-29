using System;
using System.Collections.Generic;
using System.Linq;


namespace MortgagePaymentCalculator
{
    public sealed class PaymentCalc
    {
        private readonly Loan _loanObj;

        private PaymentCalc(Loan theLoan)
        {
            _loanObj = theLoan;
        }

        public decimal APR
        {
            get
            {
                //get { return 0.0M; }
                var ret = findAPRGeq(LoanAmount, Payment(), 360, 12, _loanObj.Rate, .333m, 1);
                return DecimalUtils.RoundDecimalUp(ret);
            }
        }

        private decimal PeriodPMI => _loanObj.PMI / _loanObj.PaymentsPerYear;

        private decimal PeriodTaxes => _loanObj.PropertyTaxes / _loanObj.PaymentsPerYear;
        private decimal RatePerPayment => InterestRate / _loanObj.PaymentsPerYear;

        private decimal InterestRate => _loanObj.Rate / 100;

        private int LoanTerm => _loanObj.Term * _loanObj.PaymentsPerYear;
        private decimal LoanAmount => _loanObj.Amount - _loanObj.DownPayment;
        public static PaymentCalc CreateCalc(decimal amount, int term, decimal rate, int paymentsPerYear, decimal downPayment, decimal propertyTaxes, decimal PMI, decimal extraPayment)
        {
            Loan loan = new Loan(amount, term, rate, paymentsPerYear, downPayment, propertyTaxes, PMI, extraPayment);
            return new PaymentCalc(loan);
        }

        public decimal Payment()
        {
            decimal paymentAmount = 0.0m;
            var amortzItem =  GetPaymentStream().FirstOrDefault(item => item.MonthNro == 1);
            paymentAmount = amortzItem.PaymentAmount;
            
           return paymentAmount;
        }
        private decimal RecurrentPayment()
        {
            return DefaultPaymentCalc();
        }

        private decimal DefaultPaymentCalc()
        {
            decimal payment = (LoanAmount) * (DecimalUtils.Pow((1 + RatePerPayment), LoanTerm) * InterestRate) / (12 * (DecimalUtils.Pow((1 + RatePerPayment), LoanTerm) - 1));
            return  payment;
        }

        public List<AmortizationItem> GetAmortizationTable()
        {
            return GetPaymentStream().ToList();
        }
        private IEnumerable<AmortizationItem> GetPaymentStream()
        {
            var balance = LoanAmount;
           
            var monthlyPayment = RecurrentPayment();
            var additionPpal = _loanObj.ExtraPayment;
            int totalNumOfPayments = LoanTerm;
            for (int i = 0; i < totalNumOfPayments; i++)
            {
                if (balance > 0)
                {
                    decimal interestForMonth = balance * RatePerPayment;
                    var principalForMonth = monthlyPayment - (interestForMonth);

                    balance -= (principalForMonth + additionPpal);
                    AmortizationItem item = new AmortizationItem
                    {
                        MonthNro = i + 1,
                        Interest = DecimalUtils.RoundDecimalUp(interestForMonth),
                        Principal = DecimalUtils.RoundDecimalUp(principalForMonth),
                        Balance = DecimalUtils.RoundDecimalUp(balance),
                        PMI = DecimalUtils.RoundDecimalUp(PeriodPMI),
                        Taxes= DecimalUtils.RoundDecimalUp(PeriodTaxes),
                        ExtraPayment = additionPpal
                    };


                    yield return item;
                }
                else
                {
                    yield break;
                }
            }
        }
        private decimal GeneralEquation(int period, decimal payment, decimal initialPeriods, decimal fractions, decimal rate)
        {
            decimal retval = 0;
            for (int x = 0; x < period; x++)
                retval += payment / ((1.0M + fractions * rate) * DecimalUtils.Pow(1 + rate, initialPeriods + x));
            return retval;
        }

        //https://www.fdic.gov/regulations/laws/rules/6500-3550.html -- This is a dense read..
        //https://stackoverflow.com/questions/9329017/calculating-apr-using-reg-z-appendix-j
        private decimal findAPRGeq(decimal amount, decimal payment, int payments, decimal ppy, decimal APRGuess, decimal partial, decimal full)
        {
            decimal result;
            decimal tempguess = APRGuess;

            do
            {
                result = tempguess;
                //Step 1
                decimal i = tempguess / (100 * ppy);
                decimal a1 = GeneralEquation(payments, payment, full, partial, i);
                //Step 2
                decimal i2 = (tempguess + 0.1m) / (100 * ppy);
                decimal a2 = GeneralEquation(payments, payment, full, partial, i2);
                //Step 3
                tempguess = tempguess + 0.1m * (amount - a1) / (a2 - a1);
               
            } while (Math.Abs(result * 10000 - tempguess * 10000) > 1);

            return result;
        }
    }
}
