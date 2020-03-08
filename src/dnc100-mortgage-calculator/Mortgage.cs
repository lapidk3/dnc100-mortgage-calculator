using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_mortgage_calculator
{
    public class Mortgage
    {
        public Mortgage(double principle, double interest, int term, int period)
        {

        }

        public double Calculate()
        {
            return 0;
        }

        public double MonthlyInterestRate(double interest, int period)
        {
            return 0;
        }

        public int NumberOfPayments(int term, int period)
        {
            return 0;
        }

        public double CompoundedInterestRate(double monthlyInterestRate, int numberOfPayments)
        {
            return 0;
        }

        public double InterestQuotient(double monthlyInterestRate, double compoundedInterestRate, int numberOfPayments)
        {
            return 0;
        }
    }
}
