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
            double cost = 0;
            double benefit = 0;
            double returnOnInvestment;
            double benefitEachMonth;
            double benefitAddMonths;

            //userinput
            Console.WriteLine("Please enter the cost of your project in pounds");
            cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the benefit in pounds");
            benefit = Convert.ToDouble(Console.ReadLine());

            //working out ROI
            returnOnInvestment = ((benefit - cost) / cost) * 100;
            //Work out benfit each month
            benefitEachMonth = benefit / 36;
            //Benefit for the for loop month benefit + month benefit
            benefitAddMonths = benefit / 36;

            //declaring months to count until cost is met
            int months = 0;

            //loop to work out when the cost will be over
            for (int i = 0; benefitAddMonths <= cost; i++)
            {
                benefitAddMonths = Convert.ToInt32(benefitAddMonths + benefitEachMonth);
                months++;
            }
            Console.WriteLine("Your ROI is {0}% ", returnOnInvestment);
            
            //Enter the start date of the project
            Console.WriteLine("Enter the startDate the project will start: format (dd/mm/yyyy)");
            DateTime startDate;
            //Parse start date to check valid date
            if (DateTime.TryParse(Console.ReadLine(), out startDate))
            {
                Console.WriteLine("The cost of the project will be paid on " + startDate.AddMonths(Convert.ToInt32(months)).ToString("dd/MM/yyyy"));
               
            }
            else
            {
                Console.WriteLine("Please enter a valid date");
            }
            Console.ReadLine();
        }
    }
}
