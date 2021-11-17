using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._3_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> students = new SortedSet<string>(new Compare())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            students.Add("Rafael Rollo");
            students.Add("Fabio Gushiken");
            students.Add("Fabio Gushiken");
            students.Add("FABIO GUSHIKEN");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Compare : IComparer<string>
    {
        int IComparer<string>.Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
