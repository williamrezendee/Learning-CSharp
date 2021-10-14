using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Job { get; set; }

        public override bool Equals(object obj)
        {
            Client otherClient = obj as Client;
            if (otherClient == null)
            {
                return false;
            }
            return CPF == otherClient.CPF;
        }
    }
}
