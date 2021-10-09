namespace _07_ByteBank
{
    public class CheckingAccount
    {
        public static int TotalAccountsCreated { get; private set; }
        public Client Holder { get; set; }
        private int _agency;
        public int Agency {
            get
            {
                return _agency;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agency = value;
            } 
        }
        public int Number { get; set; }

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
            Agency = agency;
            Number = number;
            TotalAccountsCreated++;
        }

        public bool Withdraw(double value)
        {
            if (_balance < value)
            {
                return false;
            }
            _balance -= value;
            return true;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public bool Tranfer(double value, CheckingAccount destinyAccount)
        {
            if (_balance < value)
            {
                return false;
            }
            _balance -= value;
            destinyAccount.Deposit(value);
            return true;
        }
    }
}
