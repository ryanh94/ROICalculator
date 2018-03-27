using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROI_Calculator
{
    class Program
    {
        static void Main(string[] args)

        {
            ConsoleIo console = new ConsoleIo();
            do
            {
                console.Clear();

                double cost = console.GetProjectCost();

                double benefit = console.GetProjectBenefit();

                Calculations cal = new Calculations(benefit, cost);

                console.WriteRoiPercentage(cal.CalculateRoi());

                //Enter the start date of the project
                var months = cal.MonthsBeforePayback();

                //Parse start date to check valid date
                console.WriteMonthsUntilPayback(months);

            } while (console.CalculateAgain());
        }
    }
}
