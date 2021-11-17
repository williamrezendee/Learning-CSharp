using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._2_JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //família 1: Família Flintstones
            //família 2: Família Simpsons
            //família 3: Família Dona Florinda

            string[][] familias = new string[3][];
            //{
            //    {"Fred","Wilma","Pedrita"},
            //    {"homer","Marge","Lisa","Bart","Maggie"}
            //    {"Florinda", "Kiko"}
            //};

            familias[0] = new string[] {"Fred", "Wilma", "Pedrita"};
            familias[1] = new string[] {"homer", "Marge", "Lisa", "Bart", "Maggie"};
            familias[2] = new string[] {"Florinda", "Kiko"};

            foreach (var item in familias)
            {
                Console.WriteLine(string.Join(",", item));
            }
        }
    }
}
