using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount brunoAccount = new CheckingAccount();

            brunoAccount.holder = "Bruno";
            Console.WriteLine(brunoAccount.balance);
            bool withdrawResult = brunoAccount.Withdraw(500);
            Console.WriteLine(brunoAccount.balance);
            Console.WriteLine(withdrawResult);

            brunoAccount.Deposit(500);
            Console.WriteLine(brunoAccount.balance);

            CheckingAccount gabrielaAccount = new CheckingAccount();
            gabrielaAccount.holder = "Gabriela";

            brunoAccount.Tranfer(200, gabrielaAccount);
            Console.WriteLine("Bruno's balance: "+brunoAccount.balance);
            Console.WriteLine("Gabriela's balance: "+gabrielaAccount.balance);

            Console.ReadLine();
        }
    }
}
