using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    class CheckingAccount
    {
        public int Number { get; }
        public int Agency { get; }
        public double Balance { get; private set; }
        public Client Holder { get; set; }

        public CheckingAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The deposit value must be greater than zero!", nameof(value));
            }

            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The deposit value must be greater than zero!", nameof(value));
            }
            if (value > Balance)
            {
                throw new InvalidOperationException("Insuficient balance!");
            }

            Balance -= value;
        }
    }
}
