using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 8 - Variable Scope");

            int joaoAge = 18;
            bool accompanied = true;
            string message;

            if (accompanied == true)
            {
                message = "João is accompanied!";
            }
            else
            {
                message = "João isn't accompanied!";
            }


            if (joaoAge >= 18 || accompanied == true)
            {
                Console.WriteLine("João can come in");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("João can't come in");
            }
            Console.ReadLine();
        }
    }
}
