using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    class ComercialPartner : IAuthenticable
    {
        private AutheticationHelper _authenticationHelper = new AutheticationHelper();
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return _authenticationHelper.ComparePassword(Password, password);
        }
    }
}
