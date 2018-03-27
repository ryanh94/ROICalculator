using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROI_Calculator
{
    class ConsoleIo
    {
        public void WriteMonthsUntilPayback(int months)
        {
            DateTime startDate;
            do
            {
                Console.WriteLine("Enter the startDate the project will start: format (dd/mm/yyyy)");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out startDate));

            Console.WriteLine("The cost of the project will be paid on " + startDate.AddMonths(months).ToString("dd/MM/yyyy"));
        }

        public double GetProjectCost()
        {
            double cost;
            do
            {
                Console.WriteLine("Please enter the cost in pounds");
            } while (!double.TryParse(Console.ReadLine(), out cost));

            return cost;
        }

        public double GetProjectBenefit()
        {
            double benefit;
            do
            {
                Console.WriteLine("Please enter the benefit in pounds");
            }
            while (!double.TryParse(Console.ReadLine(), out benefit));

            return benefit;
        }
        public void WriteRoiPercentage(double returnOnInvestment)
        {
            Console.WriteLine($"Your ROI is {returnOnInvestment}%");
        }

        public bool CalculateAgain()
        {
            Console.WriteLine("Do you want to try again? (y/n): ");

            ConsoleKeyInfo keyPress;
            do
            {
                keyPress = Console.ReadKey(true);
            } while (keyPress.Key != ConsoleKey.Y && keyPress.Key != ConsoleKey.N);

            if (keyPress.Key == ConsoleKey.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
