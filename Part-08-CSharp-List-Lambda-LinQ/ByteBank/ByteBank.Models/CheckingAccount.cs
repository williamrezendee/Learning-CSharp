using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    /// <summary>
    /// Define a Checking Account of the ByteBank.
    /// </summary>
    public class CheckingAccount : IComparable
    {
        public static int OperationTax { get; private set; }
        public static int TotalAccountsCreated { get; private set; }
        public int CountAttemptingWithdrawNotPermitted { get; private set; }
        public int CountAttemptingTransferNotPermitted { get; private set; }

        public Client Holder { get; set; }
        public int AgencyNumber { get; }
        public int AccountNumber { get; }

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

        /// <summary>
        /// Use to create an instance of CheckingAccount with the used arguments.
        /// </summary>
        /// <param name="agency">It represents the value of the <see cref="AgencyNumber"/> property and must be greater than zero.</param>
        /// <param name="number">It represents the value of the <see cref="AccountNumber"/> property and must be greater than zero.</param>
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

            AgencyNumber = agency;
            AccountNumber = number;
            
            TotalAccountsCreated++;
            OperationTax = 30 / TotalAccountsCreated;
        }

        /// <summary>
        /// It makes Withdraw operation and update the value of <see cref="Balance"/> property.
        /// </summary>
        /// <exception cref="ArgumentException">It throwed when a nagative value is used in <paramref name="value"/>.</exception>
        /// <exception cref="InsufficientBalanceException">It throwed when the argument <paramref name="value"/> is greater than <see cref="Balance"/> property.</exception>
        /// <param name="value">It represents the withdraw value and must be greater than zero and less than <see cref="Balance"/></param>
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

        public override string ToString()
        {
            return $"Account {AccountNumber}, Agency {AgencyNumber}, Balance {Balance}";
        }

        public override bool Equals(object obj)
        {
            CheckingAccount other = obj as CheckingAccount;
            if (other == null)
            {
                return false;
            }

            return AccountNumber == other.AccountNumber && AgencyNumber == other.AgencyNumber;
        }

        public int CompareTo(object obj)
        {
            var otherAccount = obj as CheckingAccount;

            if (otherAccount == null)
            {
                return -1;
            }

            if (AccountNumber < otherAccount.AccountNumber)
            {
                return -1;
            }
            if (AccountNumber == otherAccount.AccountNumber)
            {
                return 0;
            }

            return 1;
        }
    }
}
