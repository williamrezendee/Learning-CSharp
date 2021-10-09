using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    class Designer : Employee
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }

        public override void SalaryUpgrade()
        {
            Salary *= 1.11;
        }

        public override double GetBonification()
        {
            return Salary * 0.17;
        }



    }
}
