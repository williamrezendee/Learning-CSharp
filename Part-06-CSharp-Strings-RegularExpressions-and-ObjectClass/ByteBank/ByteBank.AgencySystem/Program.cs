using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            CheckingAccount account = new CheckingAccount(456,456789);
            Console.WriteLine(account);

            Client carlos_1 = new Client();
            carlos_1.Name = "Carlos";
            carlos_1.CPF = "456.123.789-10";
            carlos_1.Job = "Designer";

            Client carlos_2 = new Client();
            carlos_2.Name = "Carlos";
            carlos_2.CPF = "456.123.789-10";
            carlos_2.Job = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("The objects are equals!");
            }
            else
            {
                Console.WriteLine("The objects aren't equals!");
            }

            Console.ReadLine();
        }

        static void StringTest()
        {
            //string pattern = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            string pattern1 = "[0-9]{4,5}-?[0-9]{4}";
            string text = "My name is William, call me on 4784-4546";

            Match result = Regex.Match(text, pattern1);
            Console.WriteLine(result.Value);
            Console.ReadLine();


            string url = "http://www.bytebank.com/exchange?originCurrency=real&destinyCurrency=dolar&value=1500";
            URLArgumentExtractor extractor = new URLArgumentExtractor(url);

            string valueOriginCurrency = extractor.GetArgumentValue("originCurrency");
            Console.WriteLine("Origin Currency Value: " + valueOriginCurrency);

            string valueDestinyCurrency = extractor.GetArgumentValue("destinyCurrency");
            Console.WriteLine("Destiny Currency Value: " + valueDestinyCurrency);
        }
    }
}
