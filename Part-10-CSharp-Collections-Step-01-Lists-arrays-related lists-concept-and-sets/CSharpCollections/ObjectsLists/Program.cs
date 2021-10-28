using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var introLesson = new Lesson("Introduction to Collections", 20);
            var modelingLesson = new Lesson("Modeling the lesson class", 18);
            var lessonSets = new Lesson("Working with sets", 16);

            List<Lesson> lessons = new List<Lesson>();
            lessons.Add(introLesson);
            lessons.Add(modelingLesson);
            lessons.Add(lessonSets);

            Print(lessons);

            lessons.Sort();
            Print(lessons);

            lessons.Sort((me, other) => me.Time.CompareTo(other.Time));
            Print(lessons);

        }

        private static void Print(List<Lesson> lessons)
        {
            Console.Clear();
            foreach (var lesson in lessons)
            {
                Console.WriteLine(lesson);
            }
            Console.WriteLine();
        }
    }

    class Lesson : IComparable
    {
        public string Title { get; set; }
        public int Time { get; set; }

        public Lesson(string title, int time)
        {
            Title = title;
            Time = time;
        }

        public override string ToString()
        {
            return $"[Title: {Title}, time: {Time} minutes]";
        }

        public int CompareTo(object obj)
        {
            var lesson = obj as Lesson;
            return Title.CompareTo(lesson.Title);
        }
    }
}
