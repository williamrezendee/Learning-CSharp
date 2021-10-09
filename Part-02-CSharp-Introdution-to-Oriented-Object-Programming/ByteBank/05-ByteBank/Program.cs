using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client gabriela = new Client();

            // gabriela.name = "Gabriela";
            // gabriela.job = "Backend Developer";
            // gabriela.cpf = "000.111.222-33";

            CheckingAccount account = new CheckingAccount();
            // account.holder = gabriela;
            
            account.holder.name = "Gabriela Costa";
            account.holder = new Client();
            account.balance = 500;
            account.agency = 563;
            account.accountNumber = 5634527;

            

            // Console.WriteLine(gabriela.name);
            Console.WriteLine(account.holder.name);

            Console.ReadLine();
        }
    }
}
