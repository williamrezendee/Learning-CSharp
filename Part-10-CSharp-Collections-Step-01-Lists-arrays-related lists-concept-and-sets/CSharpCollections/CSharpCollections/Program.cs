using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string introLesson = "Introduction to collections";
            string modelingLesson = "Modeling the class lesson";
            string setLesson = "Working with sets";

            //List<string> lessons = new List<string>
            //{
            //    introLesson,
            //    modelingLesson,
            //    setLesson
            //};

            List<string> lessons = new List<string>();
            lessons.Add(introLesson);
            lessons.Add(modelingLesson);
            lessons.Add(setLesson);

            PrintList(lessons);

            Console.WriteLine($"The first lesson is {lessons[0]}");
            Console.WriteLine($"The first lesson is {lessons.First()}");
            Console.WriteLine($"The last lesson is {lessons[lessons.Count - 1]}");
            Console.WriteLine($"The last lesson is {lessons.Last()}");

            lessons[0] = "Working with Lists";
            PrintList(lessons);

            Console.WriteLine("The first occurency of 'Working' is: "+lessons.First(lesson => lesson.Contains("Working")));
            Console.WriteLine("The last occurency of 'Working' is: "+lessons.Last(lesson => lesson.Contains("Working")));
            Console.WriteLine("The first occurency of 'Conclusion' is: " + lessons.FirstOrDefault(lesson => lesson.Contains("Conclusion")));

            lessons.Reverse();
            PrintList(lessons);

            lessons.Reverse();
            PrintList(lessons);

            lessons.RemoveAt(lessons.Count - 1);
            PrintList(lessons);

            lessons.Add("Conclusion");
            PrintList(lessons);
            
            lessons.Sort();
            PrintList(lessons);

            List<string> copy = lessons.GetRange(lessons.Count - 2, 2);
            PrintList(copy);

            List<string> clone = new List<string>(lessons);
            PrintList(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            PrintList(clone);
        }

        private static void PrintList(List<string> lessons)
        {
            //foreach (var lesson in lessons)
            //{
            //    Console.WriteLine(lesson);
            //}

            //for (int i = 0; i < lessons.Count; i++)
            //{
            //    Console.WriteLine(lessons[i]);
            //}

            lessons.ForEach(lesson => 
            {
                Console.WriteLine(lesson);
            });
        }

        private static void WorkingWithArray()
        {
            string introLesson = "Introduction to collections";
            string modelingLesson = "Modeling the class lesson";
            string setLesson = "Working with sets";

            //string[] lessons = new string[]
            //{
            //    introLesson,
            //    modelingLesson,
            //    setLesson
            //};

            string[] lessons = new string[3];
            lessons[0] = introLesson;
            lessons[1] = modelingLesson;
            lessons[2] = setLesson;

            //Console.WriteLine(lessons);
            PrintArray(lessons);

            Console.WriteLine(lessons[0]);
            Console.WriteLine(lessons[lessons.Length - 1]);

            lessons[0] = "Working with Arrays";
            PrintArray(lessons);

            Console.WriteLine($"Modeling lesson is on index {Array.IndexOf(lessons, modelingLesson)}");
            Console.WriteLine(Array.LastIndexOf(lessons, modelingLesson));
            Console.WriteLine();

            Array.Reverse(lessons);
            PrintArray(lessons);
            Console.WriteLine();

            Array.Resize(ref lessons, 2);
            PrintArray(lessons);
            Console.WriteLine();

            Array.Resize(ref lessons, 3);
            PrintArray(lessons);
            Console.WriteLine();

            lessons[lessons.Length - 1] = "Conclusion";
            PrintArray(lessons);
            Console.WriteLine();

            Array.Sort(lessons);
            PrintArray(lessons);
            Console.WriteLine();

            string[] copy = new string[2];
            Array.Copy(lessons, 1, copy, 0, 2);
            PrintArray(copy);

            string[] clone = lessons.Clone() as string[];
            PrintArray(clone);
            Console.WriteLine();

            Array.Clear(clone, 1, 2);
            PrintArray(clone);
        }

        private static void PrintArray(string[] lessons)
        {
            //foreach (var lesson in lessons)
            //{
            //    Console.WriteLine(lesson);
            //}

            for (int i = 0; i < lessons.Length; i++)
            {
                Console.WriteLine(lessons[i]);
            }
        }
    }
}
