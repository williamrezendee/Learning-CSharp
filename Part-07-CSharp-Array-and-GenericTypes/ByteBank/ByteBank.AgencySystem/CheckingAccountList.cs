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

        public CheckingAccountList(int initialCapacity = 5)
        {
            _accounts = new CheckingAccount[initialCapacity];
            _nextPosition = 0;
        }

        public void Add(CheckingAccount account)
        {
            CapacityVerificator(_nextPosition + 1);
            Console.WriteLine($"Adding an account on position {_nextPosition}");
            _accounts[_nextPosition] = account;
            _nextPosition++;
        }

        public void Remove(CheckingAccount account)
        {
            // Code here...
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

            Console.WriteLine($"Expanding array's capacity!");
            CheckingAccount[] newArray = new CheckingAccount[newSize];
            for (int index = 0; index < _accounts.Length; index++)
            {
                newArray[index] = _accounts[index];
                Console.WriteLine(".");
            }
            _accounts = newArray;
        }
    }
}
