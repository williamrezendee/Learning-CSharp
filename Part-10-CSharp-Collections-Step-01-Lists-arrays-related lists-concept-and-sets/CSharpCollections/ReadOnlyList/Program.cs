using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Course csharpCollections = new Course("C# Collections", "Marcelo Oliveira");
            csharpCollections.Add(new Lesson("Working with lists", 21));
            Print(csharpCollections.Lessons);

            // Add 2 lessons
            csharpCollections.Add(new Lesson("Creating a lesson", 20));
            csharpCollections.Add(new Lesson("Modeling with Collections", 19));

            // Printing
            Print(csharpCollections.Lessons);

            // Coping the main list to another list
            List<Lesson> copiedLessons = new List<Lesson>(csharpCollections.Lessons);

            // Ordering the copied list
            copiedLessons.Sort();
            Print(copiedLessons);

            // Totalizing the time of the courses
            Console.WriteLine(csharpCollections.TotalTime);
            Console.WriteLine(csharpCollections);
        }

        private static void Print(IList<Lesson> lessons)
        {
            Console.Clear();
            foreach (var lesson in lessons)
            {
                Console.WriteLine(lesson);
            }
            Console.WriteLine();
        }
    }
}
