using ByteBank.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
    }
}
