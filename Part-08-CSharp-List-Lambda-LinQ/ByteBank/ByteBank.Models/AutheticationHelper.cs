using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    class AutheticationHelper
    {
        public bool ComparePassword(string truePassword, string TryPassword)
        {
            return truePassword == TryPassword;
        }
    }
}
