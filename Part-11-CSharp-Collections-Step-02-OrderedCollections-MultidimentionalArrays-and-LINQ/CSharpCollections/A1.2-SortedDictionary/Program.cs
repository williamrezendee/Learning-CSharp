using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Student> sorted = new SortedDictionary<string, Student>();

            sorted.Add("VT", new Student("Vanessa", 34672));
            sorted.Add("AL", new Student("Ana", 56175));
            sorted.Add("RN", new Student("Rafael", 17645));
            sorted.Add("WM", new Student("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

        }
    }
}
