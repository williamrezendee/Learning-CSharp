using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Models;
using ByteBank.Models.Employees;

namespace ByteBank.AgencySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccountList list = new CheckingAccountList();

            CheckingAccount williamAccount = new CheckingAccount(456, 345890);

            list.Add(new CheckingAccount(456, 456789));
            list.Add(new CheckingAccount(456, 456123));
            list.Add(new CheckingAccount(456, 456234));
            list.Add(new CheckingAccount(456, 123456));
            list.Add(new CheckingAccount(456, 987654));
            list.Add(new CheckingAccount(456, 345234));
            list.Add(new CheckingAccount(456, 556677));
            list.Add(new CheckingAccount(456, 889900));
            list.Add(new CheckingAccount(456, 443322));
            list.Add(new CheckingAccount(456, 112233));
            list.Add(williamAccount);

            list.Remove(williamAccount); // The Method need to be implemented.
        }

        static void ArrayTestCheckingAccount()
        {
            CheckingAccount[] accounts = new CheckingAccount[]
            {
                new CheckingAccount(456, 456789),
                new CheckingAccount(456, 456123),
                new CheckingAccount(456, 456234)
            };

            for (int index = 0; index < accounts.Length; index++)
            {
                CheckingAccount currentAccount = accounts[index];
                Console.WriteLine($"Account {index} {currentAccount.AccountNumber}");
            }
        }

        static void ArrayTestInt()
        {
            int[] ages = new int[5];

            ages[0] = 15;
            ages[1] = 28;
            ages[2] = 35;
            ages[3] = 50;
            ages[4] = 28;

            int counter = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                int age = ages[i];
                Console.WriteLine($"Accessing ages array on index {i}");
                Console.WriteLine($"Value of ages[{i}] = {age}");
                counter += age;
            }

            int avarage = counter / ages.Length;
            Console.WriteLine($"Ages' avarage: {avarage}");
        }
    }
}
