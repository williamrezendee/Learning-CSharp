using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_SortedDictionary
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        private int registrationNumber;

        public int RegistrationNumber
        {
            get { return registrationNumber; }
        }

        public Student(string name, int registrationNumber)
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return "[Aluno: " + name + ", matricula: " + registrationNumber + "]";
        }
    }
}
