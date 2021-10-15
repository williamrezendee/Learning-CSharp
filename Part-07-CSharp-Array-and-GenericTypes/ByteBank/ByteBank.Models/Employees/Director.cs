using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Employees
{
    public class Director : AuthenticableEmployee
    {
        public Director(string cpf) : base(cpf, 5000)
        {
        }


        internal protected override double GetBonification()
        {
            return Salary * 0.5;
        }

        public override void SalaryUpgrade()
        {
            Salary *= 1.15;
        }
    }
}
