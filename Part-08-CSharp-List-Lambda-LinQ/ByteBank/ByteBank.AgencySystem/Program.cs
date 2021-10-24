using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Models;
using ByteBank.Models.Employees;
using ByteBank.AgencySystem.Extensions;
using ByteBank.AgencySystem.Comparers;

namespace ByteBank.AgencySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<CheckingAccount>()
            {
                new CheckingAccount(321, 456789),
                null,
                new CheckingAccount(322, 234567),
                new CheckingAccount(320, 123456),
                null,
                null,
                new CheckingAccount(315, 456123)
            };

            var ordenadedAccounts = accounts
                .Where(account => account != null)
                .OrderBy(account => account.AgencyNumber);

            foreach (var account in ordenadedAccounts)
            {
                Console.WriteLine($"Account number {account.AccountNumber}, ag. {account.AgencyNumber}");
            }

            Console.ReadLine();
        }

        static void SortMethodTester()
        {
            var names = new List<string>()
            {
                "William",
                "Bruna",
                "Eloa",
                "Anne"
            };

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            var ages = new List<int>();

            ages.Add(1);
            ages.Add(5);
            ages.Add(14);
            ages.Add(25);
            ages.Add(38);
            ages.Add(61);

            ages.AddSeveral(3, 4, 7);

            ages.Sort();

            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }
        }
        
        static void IntegerListTester()
        {
            ObjectList agesList = new ObjectList();

            agesList.Add(10);
            agesList.Add(5);
            agesList.Add(4);
            agesList.AddSeveralItems(16, 23, 60);

            for (int i = 0; i < agesList.Length; i++)
            {
                int age = (int)agesList[i];
                Console.WriteLine($"Age on {i} index: {age}");
            }
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
