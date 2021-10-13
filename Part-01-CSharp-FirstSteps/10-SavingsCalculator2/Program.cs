using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SavingsCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 10");

            double investedValue = 1000;

            for (int count = 1; count <= 12; count++)
            {
                investedValue *= 1.0036;
                Console.WriteLine($"After {count} you got $ {investedValue}");
            }

            Console.ReadLine();
        }
    }
}
