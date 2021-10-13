using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.InternalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount(123, 123456);
            Console.WriteLine(account.Balance);

            account.Withdraw(-10);
            string name = "William";

            Console.ReadLine();
        }
    }
}
