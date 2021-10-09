using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Director : AuthenticableEmployee
    {
        public Director(string cpf) : base(cpf, 5000)
        {
        }


        public override double GetBonification()
        {
            return Salary * 0.5;
        }

        public override void SalaryUpgrade()
        {
            Salary *= 1.15;
        }
    }
}
