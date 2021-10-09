using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        public string Password { get; set; }

        public AuthenticableEmployee(string cpf, double salary) 
            : base(cpf, salary)
        {
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
