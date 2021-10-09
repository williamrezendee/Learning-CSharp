using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Models;
using ByteBank.Models.Employees;
using Humanizer;

namespace ByteBank.AgencySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime endPaymentDate = new DateTime(2021, 12, 8);
            DateTime currentDate = DateTime.Now;

            TimeSpan difference = endPaymentDate - currentDate;

            Console.WriteLine(currentDate);
            Console.WriteLine(endPaymentDate);
            Console.WriteLine($"Maturity in: {TimeSpanHumanizeExtensions.Humanize(difference)}");

            Console.ReadLine();
        }
    }
}
