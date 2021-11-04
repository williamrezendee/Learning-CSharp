using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Queue
{
    class Program
    {
        static Queue<string> _tolling = new Queue<string>();

        static void Main(string[] args)
        {
            Enqueue("Van");
            Enqueue("Kombi");
            Enqueue("Guincho");
            Enqueue("Pickup");
            ShowQueue();
            Dequeue();
            ShowQueue();

            Console.WriteLine();
        }

        private static void Enqueue(string vehicle)
        {
            Console.WriteLine($"Joined the queue: {vehicle}");
            _tolling.Enqueue(vehicle);
        }

        private static void Dequeue()
        {
            if (_tolling.Any())
            {
                string vehicle = _tolling.Dequeue();
                Console.WriteLine($"Leave the queue: {vehicle}");
            }
        }

        private static void ShowQueue()
        {
            Console.Write("Queue: ");
            foreach (var v in _tolling)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }
    }
}
            
