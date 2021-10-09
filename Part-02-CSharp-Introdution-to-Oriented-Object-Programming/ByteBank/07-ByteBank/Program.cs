using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckingAccount.TotalAccountsCreated);

            CheckingAccount account = new CheckingAccount(8624, 12345678);
            Console.WriteLine(CheckingAccount.TotalAccountsCreated);

            Console.WriteLine(account.Agency);
            Console.WriteLine(account.Number);

            Console.ReadLine();
        }
    }
}
