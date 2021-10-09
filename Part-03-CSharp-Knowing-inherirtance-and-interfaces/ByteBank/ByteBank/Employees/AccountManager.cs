using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
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

        public override double GetBonification()
        {
            return Salary * 0.25;
        }
    }
}
