﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Employees
{
    class Developer : Employee
    {
        public Developer(string cpf) : base(cpf, 3000)
        {
        }

        internal protected override double GetBonification()
        {
            return Salary * 0.1;
        }

        public override void SalaryUpgrade()
        {
            Salary *= 0.15;
        }
    }
}
