using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyList
{
    class Course
    {
        private IList<Lesson> _lessons;

        public IList<Lesson> Lessons
        {
            get { return new ReadOnlyCollection<Lesson>(_lessons); }
        }

        private string _name;
        private string _instructor;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        public int TotalTime 
        { 
            get 
            {
                //int total = 0;
                //foreach (var lesson in _lessons)
                //{
                //    total += lesson.Time;
                //}

                //return total;

                return _lessons.Sum(lesson => lesson.Time);
            } 
        }

        public Course(string name, string instructor)
        {
            _name = name;
            _instructor = instructor;
            _lessons = new List<Lesson>();
        }
        internal void Add(Lesson lesson)
        {
            _lessons.Add(lesson);
        }

        public override string ToString()
        {
            return $"Coure: {Name}, Time: {TotalTime}, Lessons: {string.Join(",", _lessons)}";
        }

    }
}
