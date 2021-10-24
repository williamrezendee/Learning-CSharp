using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem.Comparers
{
    class CheckingAccountAgencyComparer : IComparer<CheckingAccount>
    {
        public int Compare(CheckingAccount x, CheckingAccount y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            if (x.AgencyNumber < y.AgencyNumber)
            {
                return -1;
            }

            if (x.AgencyNumber < y.AgencyNumber)
            {
                return 0;
            }

            return 1;


            // It can be used this code too
            // return x.AgencyNumber.CompareTo(y.AgencyNumber);
        }
    }
}
