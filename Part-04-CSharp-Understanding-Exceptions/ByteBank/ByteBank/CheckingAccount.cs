using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CheckingAccount
    {
        public static int OperationTax { get; private set; }
        public static int TotalAccountsCreated { get; private set; }
        public int CountAttemptingWithdrawNotPermitted { get; private set; }
        public int CountAttemptingTransferNotPermitted { get; private set; }

        public Client Holder { get; set; }
        public int Agency { get; }
        public int Number { get; }

        private double _balance = 100;
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _balance = value;
            }
        }

        public CheckingAccount(int agency, int number)
        {
            if (agency <= 0)
            {
                throw new ArgumentException("The agency argument must be greater than 0.", nameof(agency));
            }
            if (number <= 0)
            {
                throw new ArgumentException("The number argument must be greater than 0.", nameof(number));
            }

            Agency = agency;
            Number = number;
            
            TotalAccountsCreated++;
            OperationTax = 30 / TotalAccountsCreated;
        }

        public void Withdraw(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid withdraw! It's not permitted withdraw with negative value.", nameof(value));
            }
            if (_balance < value)
            {
                CountAttemptingWithdrawNotPermitted++;
                throw new InsufficientBalanceException(_balance, value);
            }
            _balance -= value;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public void Tranfer(double value, CheckingAccount destinyAccount)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid transfer! It's not permitted tranfer with negative value.", nameof(value));
            }
            try
            {
                Withdraw(value);
            }
            catch (InsufficientBalanceException e)
            {
                CountAttemptingTransferNotPermitted++;
                throw new FinanceOperationException("The transfer operation wasn't made!", e);
            }

            destinyAccount.Deposit(value);
        }
    }
}
