using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class InsufficientBalanceException : FinanceOperationException
    {
        public double Balance { get; }
        public double WithdrawValue { get; }

        public InsufficientBalanceException()
        {
        }
        public InsufficientBalanceException(string message) 
            : base(message)
        {
        }
        public InsufficientBalanceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InsufficientBalanceException(double balance, double withdrawValue)
            : this($"An attempt was made to withdraw {withdrawValue} from an account with a balance of {balance}.")
        {
            Balance = balance;
            WithdrawValue = withdrawValue;
        }

    }
}
