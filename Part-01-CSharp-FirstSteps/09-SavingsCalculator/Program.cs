using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SavingsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 10 - Savings Calculator");

            double investedValue = 1000;
            int count = 1;

            while (count <= 12)
            {
                investedValue = investedValue + investedValue * 0.0036;
                count++;
            }

            Console.WriteLine($"After {count-1} month, you got $ {investedValue}");

            Console.ReadLine();
        }
    }
}
