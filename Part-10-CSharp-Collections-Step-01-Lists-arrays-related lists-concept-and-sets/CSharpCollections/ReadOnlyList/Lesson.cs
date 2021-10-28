using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyList
{
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
