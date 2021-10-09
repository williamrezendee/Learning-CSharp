using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumericTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 4");

            double salary;
            salary = 1200.50;

            // int is a variable type of 32 bits
            int integerSalary = (int)salary;
            Console.WriteLine(integerSalary);

            // long is a variable type of 64 bits
            long age = 13000000000;
            Console.WriteLine(age);

            // short is a variable type of 16 bits
            short productsQuantity = 15000;
            Console.WriteLine(productsQuantity);

            float height = 1.80f;
            Console.WriteLine(height);


            Console.WriteLine("Execution finished! Press Enter to close this window...");
            Console.ReadLine();
        }
    }
}
