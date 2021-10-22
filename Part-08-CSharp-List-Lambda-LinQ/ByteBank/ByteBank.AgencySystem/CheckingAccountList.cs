using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem
{
    public class CheckingAccountList
    {
        private CheckingAccount[] _accounts;
        private int _nextPosition;

        public int Length
        {
            get
            {
                return _nextPosition;
            }
        }

        public CheckingAccountList(int initialCapacity = 5)
        {
            _accounts = new CheckingAccount[initialCapacity];
            _nextPosition = 0;
        }

        public void Add(CheckingAccount account)
        {
            CapacityVerificator(_nextPosition + 1);
            //Console.WriteLine($"Adding an account on position {_nextPosition}");
            _accounts[_nextPosition] = account;
            _nextPosition++;
        }

        public void AddSeveralAccounts(params CheckingAccount[] accounts)
        {
            foreach (CheckingAccount account in accounts)
            {
                Add(account);
            }
        }

        public void Remove(CheckingAccount account)
        {
            int accountIndex = -1;

            for (int i = 0; i < _nextPosition; i++)
            {
                if (_accounts[i].Equals(account))
                {
                    accountIndex = i;
                    break;
                }
            }

            for (int i = accountIndex; i < _nextPosition - 1; i++)
            {
                _accounts[i] = _accounts[i + 1];
            }

            _nextPosition--;
            _accounts[_nextPosition] = null;
        }

        public CheckingAccount GetCheckingAccountOnIndex(int index)
        {
            if (index < 0 || index >= _nextPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return _accounts[index];

        }

        private void CapacityVerificator(int sizeNeeded)
        {
            if (_accounts.Length >= sizeNeeded)
            {
                return;
            }

            int newSize = _accounts.Length * 2;
            if (newSize < sizeNeeded)
            {
                newSize = sizeNeeded;
            }

            //Console.WriteLine($"Expanding array's capacity!");
            CheckingAccount[] newArray = new CheckingAccount[newSize];
            for (int index = 0; index < _accounts.Length; index++)
            {
                newArray[index] = _accounts[index];
                //Console.WriteLine(".");
            }
            _accounts = newArray;
        }

        public CheckingAccount this[int index] // Indexer
        {
            get
            {
                return GetCheckingAccountOnIndex(index);
            }
        }
    }
}
