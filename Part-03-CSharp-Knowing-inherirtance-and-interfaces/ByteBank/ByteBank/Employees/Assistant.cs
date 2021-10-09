using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    class Assistant : Employee
    {
        public Assistant(string cpf) : base(cpf, 2000)
        {
        }

        public override void SalaryUpgrade()
        {
            Salary *= 1.1;
        }

        public override double GetBonification()
        {
            return Salary * 0.2;
        }
    }
}
