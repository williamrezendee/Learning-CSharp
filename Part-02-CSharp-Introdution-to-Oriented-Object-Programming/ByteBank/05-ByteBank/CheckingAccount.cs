namespace _05_ByteBank
{
    public class CheckingAccount
    {
        public Client holder;
        public int agency;
        public int accountNumber;
        public double balance = 100;

        public bool Withdraw(double value)
        {
            if (this.balance < value)
            {
                return false;
            }
            else
            {
                this.balance -= value;
                return true;
            }
        }

        public void Deposit(double value)
        {
            this.balance += value;
        }

        public bool Tranfer(double value, CheckingAccount destinyAccount)
        {
            if (this.balance < value)
            {
                return false;
            }
            else
            {
                this.balance -= value;
                destinyAccount.Deposit(value);
                return true;
            }
        }
    }
}
