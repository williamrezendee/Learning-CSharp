using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    class InternalSystem
    {
        public bool LogOn(IAuthenticable employee, string password)
        {
            bool isAuthenticatedUser = employee.Authenticate(password);
            if (isAuthenticatedUser)
            {
                Console.WriteLine("Welcome to the system!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry! The password isn't correct!");
                return false;
            }
        }
    }
}
