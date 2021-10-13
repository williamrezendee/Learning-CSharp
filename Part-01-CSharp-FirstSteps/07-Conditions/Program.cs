using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 7 - CSharp Conditions");

            int joaoAge = 16;
            int peopleQuantity = 2;

            if (joaoAge >= 18 || peopleQuantity >= 2)
            {
                Console.WriteLine("João can come in");
            }
            else
            {
                Console.WriteLine("João can't come in");
            }
            Console.ReadLine();
        }
    }
}
