using ByteBank.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem
{
    class Intern : Employee
    {
        public Intern(string cpf, double salary)
            : base(cpf, salary)
        {
        }

        public override void SalaryUpgrade()
        {
            // Code here...
        }

        protected override double GetBonification()
        {
            // Code here
            return 1;
        }
    }
}
