using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>()
            {
                "Abacate", "Banana", "Caqui", "Damasco", "Figo"
            };

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            LinkedList<string> days = new LinkedList<string>();
            var d4 = days.AddFirst("Quarta-feira");
            var d2 = days.AddBefore(d4, "Segunda-feira");
            var d3 = days.AddAfter(d2, "Terça-feira");
            var d6 = days.AddAfter(d4, "Sexta-feira");
            var d7 = days.AddAfter(d6, "Sábado");
            var d5 = days.AddBefore(d6, "Quinta-feira");
            var d1 = days.AddBefore(d2, "Domingo");

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();
            var quarta = days.Find("Quarta-feira");
            Console.WriteLine(quarta);

        }
    }
}
