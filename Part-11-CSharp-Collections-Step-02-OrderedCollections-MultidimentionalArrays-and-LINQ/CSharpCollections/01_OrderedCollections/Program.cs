using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._1_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IDictionary<string, Student> students = new Dictionary<string, Student>();

            students.Add("VT", new Student("Vanessa", 34672));
            students.Add("AL", new Student("Ana", 56175));
            students.Add("RN", new Student("Rafael", 17645));
            students.Add("WM", new Student("Wanderson", 11287));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            students.Remove("AL");
            students.Add("MO", new Student("Marcelo", 12345));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            */

            IDictionary<string, Student> sorted = new SortedList<string, Student>();

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
