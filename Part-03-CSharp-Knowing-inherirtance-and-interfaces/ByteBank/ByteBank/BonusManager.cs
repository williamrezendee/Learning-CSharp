using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class BonusManager
    {
        private double _TotalBonification;

        public void Registrate(Employee employee)
        {
            _TotalBonification += employee.GetBonification();
        }

        public double GetTotalBonification()
        {
            return _TotalBonification;
        }
    }
}
