using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AttributionsOfVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 6 - Attributions of variables");

            int age = 32;
            int gustavoAge = age;

            age = 20;

            Console.WriteLine(age);
            Console.WriteLine(gustavoAge);

            Console.ReadLine();
        }
    }
}
