using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        AutheticationHelper _autheticationHelper = new AutheticationHelper();
        public string Password { get; set; }

        public AuthenticableEmployee(string cpf, double salary) 
            : base(cpf, salary)
        {
        }

        public bool Authenticate(string password)
        {
            return _autheticationHelper.ComparePassword(Password, password);
        }
    }
}
