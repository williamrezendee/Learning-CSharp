﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployees { get; private set; }
        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Salary { get; protected set; }

        public Employee(string cpf, double salary)
        {
            Salary = salary;
            CPF = cpf;
            TotalEmployees++;
        }

        public abstract void SalaryUpgrade();

        internal protected abstract double GetBonification();
    }
}
