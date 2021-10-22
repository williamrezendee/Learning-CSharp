using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Employees
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

        internal protected override double GetBonification()
        {
            return Salary * 0.2;
        }
    }
}
