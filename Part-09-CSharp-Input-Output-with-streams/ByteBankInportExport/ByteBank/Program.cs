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
            var lines = File.ReadAllLines("accounts.txt");
            Console.WriteLine(lines.Length);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            var bytesFile = File.ReadAllBytes("accounts.txt");
            Console.WriteLine($"The file 'accounts.txt' has {bytesFile.Length} bytes.");

            Console.ReadLine();

            UseInputStream();
            Console.WriteLine("Application ended...");
            Console.ReadLine();
        }
    }
}
