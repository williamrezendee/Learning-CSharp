using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TextsAndCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the project 5 - Texts and Characters.");

            char firstLetter = 'a';
            Console.WriteLine(firstLetter);

            firstLetter = (char)65;
            Console.WriteLine(firstLetter);

            firstLetter = (char)(firstLetter + 1);
            Console.WriteLine(firstLetter);

            string title = "Alura courses of techonology " + 2021;
            string programmingCourses = @" - .NET
                - Java
                - Javascript";
            Console.WriteLine(title);
            Console.WriteLine(programmingCourses);

            Console.WriteLine("Execution Finished! Press Enter to close this window...");
            Console.ReadLine();
        }
    }
}
