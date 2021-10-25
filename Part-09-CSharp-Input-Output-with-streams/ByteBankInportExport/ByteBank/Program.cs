using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var fileAddress = "accounts.txt";

            using (var fileStream = new FileStream(fileAddress, FileMode.Open))
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }

            Console.ReadLine();
        }
    }
}
