using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount();
            Client client = new Client();

            client.Name = "William";
            client.CPF = "000.111.222-33";
            client.Job = "Developer";

            account.Balance = -10;
            account.Holder = client;

            Console.WriteLine(account.Holder.Name);
            Console.WriteLine(account.Balance);

            Console.ReadLine();
        }
    }
}
