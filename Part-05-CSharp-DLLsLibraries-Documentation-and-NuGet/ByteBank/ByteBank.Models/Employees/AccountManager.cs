using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Employees
{
    class AccountManager : AuthenticableEmployee
    {
        public AccountManager(string cpf) : base(cpf, 4000)
        {
        }

        public override void SalaryUpgrade()
        {
            Salary *= 1.05;
        }

        internal protected override double GetBonification()
        {
            return Salary * 0.25;
        }
    }
}
