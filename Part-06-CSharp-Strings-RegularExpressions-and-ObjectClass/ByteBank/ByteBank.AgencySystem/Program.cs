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
            string url = "http://www.bytebank.com/exchange?originCurrency=real&destinyCurrency=dolar";
            URLArgumentExtractor extractor = new URLArgumentExtractor(url);

            string valueOriginCurrency = extractor.GetArgumentValue("originCurrency");
            Console.WriteLine("Origin Currency Value: " + valueOriginCurrency);

            string valueDestinyCurrency = extractor.GetArgumentValue("destinyCurrency");
            Console.WriteLine("Destiny Currency Value: " + valueDestinyCurrency);

            Console.ReadLine();
        }
    }
}
