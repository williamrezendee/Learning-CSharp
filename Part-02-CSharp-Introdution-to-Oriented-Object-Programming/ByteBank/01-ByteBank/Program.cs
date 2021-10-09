using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount gabrielaAccount = new CheckingAccount();
            gabrielaAccount.holder = "Gabriela";
            gabrielaAccount.agency = 863;
            gabrielaAccount.accountNumber = 863452;
            gabrielaAccount.balance = 100;

            Console.WriteLine("Holder: "+gabrielaAccount.holder);
            Console.WriteLine("Agency: "+gabrielaAccount.agency);
            Console.WriteLine("Account Number: "+gabrielaAccount.accountNumber);
            Console.WriteLine("Balance: "+gabrielaAccount.balance);

            gabrielaAccount.balance += 200;
            Console.WriteLine("Balance: "+gabrielaAccount.balance);



            Console.ReadLine();
        }
    }
}
