using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount();

            account.holder = "Gabriela";

            Console.WriteLine(account.holder);
            Console.WriteLine(account.agency);
            Console.WriteLine(account.balance);

            Console.ReadLine();
        }
    }
}
