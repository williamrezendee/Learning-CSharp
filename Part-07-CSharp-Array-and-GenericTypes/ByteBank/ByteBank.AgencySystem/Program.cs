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
            Console.WriteLine(SumSeveralNumbers(1, 2, 3, 4, 5, 6, 7, 8));
            
        }

        static int SumSeveralNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static void CheckingAccountListTester()
        {
            CheckingAccountList list = new CheckingAccountList();

            CheckingAccount williamAccount = new CheckingAccount(111, 111111);

            CheckingAccount[] accounts = new CheckingAccount[]
            {
                williamAccount,
                new CheckingAccount(456, 456789),
                new CheckingAccount(456, 456123)
            };

            list.AddSeveralAccounts(accounts);

            list.AddSeveralAccounts(
                williamAccount,
                new CheckingAccount(456, 456789),
                new CheckingAccount(456, 456123)
            );

            for (int i = 0; i < list.Length; i++)
            {
                CheckingAccount currentAccount = list[i];
                Console.WriteLine($"Account {i} = {currentAccount.AgencyNumber} / {currentAccount.AccountNumber}");
            }

            list.Remove(williamAccount);
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
