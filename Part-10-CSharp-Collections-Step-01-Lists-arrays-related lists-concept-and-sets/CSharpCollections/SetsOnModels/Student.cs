using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOnModels
{
    class Student
    {
        private string _name;
        private int _registration;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Registration
        {
            get { return _registration; }
            set { _registration = value; }
        }
        public Student(string name, int registration)
        {
            _name = name;
            _registration = registration;
        }

        public override string ToString()
        {
            return $"[Student: {Name}, Registration: {Registration}]";
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            return Name.Equals(student.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    }
}
