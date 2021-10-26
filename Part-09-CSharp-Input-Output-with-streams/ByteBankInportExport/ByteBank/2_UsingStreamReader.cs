using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    partial class Program
    {
        static void UsingStreamReaderDirectly() 
        {
            var fileAddress = "accounts.txt";

            using (var fileStream = new FileStream(fileAddress, FileMode.Open))
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var checkingAccount = StringToCheckingAccountCoverter(line);
                    var message = $"{checkingAccount.Holder.Name} : account number {checkingAccount.Number}, ag. {checkingAccount.Agency}, balance {checkingAccount.Balance}";
                    Console.WriteLine(message);
                }
            }
        }

        static CheckingAccount StringToCheckingAccountCoverter(string line)
        {
            var elements = line.Split(',');

            var agencyNumber = int.Parse(elements[0]);
            var accountNumber = int.Parse(elements[1]);
            var balance = double.Parse(elements[2]);

            var holder = new Client();
            holder.Name = elements[3];

            var account = new CheckingAccount(agencyNumber, accountNumber);
            account.Deposit(balance);
            account.Holder = holder;

            return account;
        }
    }
}