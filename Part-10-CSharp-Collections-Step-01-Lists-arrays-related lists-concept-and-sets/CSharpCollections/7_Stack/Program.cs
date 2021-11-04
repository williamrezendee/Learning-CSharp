using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var _browser = new Browser();
            _browser.BrowseFor("www.google.com.br");
            _browser.BrowseFor("www.caelum.com.br");
            _browser.BrowseFor("www.alura.com.br");

            _browser.GoBackToEarlierPage();
            _browser.GoBackToEarlierPage();
            _browser.GoBackToEarlierPage();
            _browser.GoBackToEarlierPage();

            _browser.GoToNextPage();
            _browser.GoToNextPage();
            _browser.GoToNextPage();

        }
    }

    internal class Browser
    {
        private readonly Stack<string> _earlierHistory = new Stack<string>();
        private readonly Stack<string> _nextHistory = new Stack<string>();

        private string _currentPage = "Empty";
        public Browser()
        {
            Console.WriteLine("Current Page: "+_currentPage);
        }

        internal void BrowseFor(string url)
        {
            _earlierHistory.Push(_currentPage);
            _currentPage = url;
            Console.WriteLine("Current Page: "+_currentPage);
        }

        internal void GoBackToEarlierPage()
        {
            if (_earlierHistory.Any())
            {
                _nextHistory.Push(_currentPage);
                _currentPage = _earlierHistory.Pop();
                Console.WriteLine("Current Page: "+_currentPage);
            }
        }

        internal void GoToNextPage()
        {
            if (_nextHistory.Any())
            {
                _earlierHistory.Push(_currentPage);
                _currentPage = _nextHistory.Pop();
                Console.WriteLine("Current Page: "+_currentPage);
            }
        }
    }
}
