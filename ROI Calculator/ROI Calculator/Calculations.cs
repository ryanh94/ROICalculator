using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROI_Calculator
{
    class Calculations
    {
        private readonly double _benefit;
        private readonly double _cost;

        public Calculations(double benefit, double cost)
        {
            _benefit = benefit;
            _cost = cost;
        }

        public double CalculateRoi()
        {
            double returnOnInvestment = ((_benefit - _cost) / _cost) * 100;

            return returnOnInvestment;
        }

        public int MonthsBeforePayback()
        {
            //Work out benfit each month
            double benefitEachMonth = _benefit / 36;

            //Benefit for the for loop month benefit + month benefit
            double benefitSoFar = benefitEachMonth;

            //declaring months to count until cost is met

            int months = 0;

            //loop to work out when the cost will be over
            for (; benefitSoFar <= _cost; months++)
            {
                benefitSoFar += benefitEachMonth;
            }
            return months;
        }
}
