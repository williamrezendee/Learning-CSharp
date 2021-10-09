using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount gabrielaAccount = new CheckingAccount();
            gabrielaAccount.holder = "Gabriela";
            gabrielaAccount.agency = 863;
            gabrielaAccount.accountNumber = 863452;

            CheckingAccount gabrielaCostaAccount = new CheckingAccount();
            gabrielaCostaAccount.holder = "Gabriela";
            gabrielaCostaAccount.agency = 863;
            gabrielaCostaAccount.accountNumber = 863452;

            Console.WriteLine("Reference type equality: "+(gabrielaAccount == gabrielaCostaAccount));

            gabrielaAccount = gabrielaCostaAccount;
            Console.WriteLine("Reference type equality: " + (gabrielaAccount == gabrielaCostaAccount));

            gabrielaAccount.balance = 300;
            Console.WriteLine(gabrielaAccount.balance);
            Console.WriteLine(gabrielaCostaAccount.balance);

            if (gabrielaAccount.balance >= 100)
            {
                gabrielaAccount.balance -= 100;
            }


            Console.ReadLine();
        }
    }
}
