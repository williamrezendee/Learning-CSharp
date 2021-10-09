using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InvestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 11");

            double investingTax = 1.0036;
            double investedValue = 1000;

            for (int yearCounter = 1; yearCounter <= 5; yearCounter++)
            {
                for (int monthCounter = 1; monthCounter <= 12 ; monthCounter++)
                {
                    investedValue *= investingTax;
                }
                investingTax += 0.001;
            }
            Console.WriteLine($"After the end of your investiment, you got $ {investedValue}");

            Console.ReadLine();
        }
    }
}
