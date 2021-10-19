using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem
{
    public class GenericList<T>
    {
        private T[] _items;
        private int _nextPosition;

        public int Length
        {
            get
            {
                return _nextPosition;
            }
        }

        public GenericList(int initialCapacity = 5)
        {
            _items = new T[initialCapacity];
            _nextPosition = 0;
        }

        public void Add(T item)
        {
            CapacityVerificator(_nextPosition + 1);
            //Console.WriteLine($"Adding an account on position {_nextPosition}");
            _items[_nextPosition] = item;
            _nextPosition++;
        }

        public void AddSeveralItems(params T[] items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public void Remove(T item)
        {
            int itemIndex = -1;

            for (int i = 0; i < _nextPosition; i++)
            {
                T currentItem = _items[i];

                if (currentItem.Equals(item))
                {
                    itemIndex = i;
                    break;
                }
            }

            for (int i = itemIndex; i < _nextPosition - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _nextPosition--;
            //_items[_nextPosition] = default;
        }

        public T GetItemOnIndex(int index)
        {
            if (index < 0 || index >= _nextPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return _items[index];

        }

        private void CapacityVerificator(int sizeNeeded)
        {
            if (_items.Length >= sizeNeeded)
            {
                return;
            }

            int newSize = _items.Length * 2;
            if (newSize < sizeNeeded)
            {
                newSize = sizeNeeded;
            }

            //Console.WriteLine($"Expanding array's capacity!");
            T[] newArray = new T[newSize];
            for (int index = 0; index < _items.Length; index++)
            {
                newArray[index] = _items[index];
                //Console.WriteLine(".");
            }
            _items = newArray;
        }

        public T this[int index] // Indexer
        {
            get
            {
                return GetItemOnIndex(index);
            }
        }
    }
}
