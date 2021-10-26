using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    partial class Program
    {
        static void CreateFile()
        {
            var pathFile = "AccountsExported.csv";

            using (var fileStream = new FileStream(pathFile, FileMode.Create))
            {
                var accountAsString = "456,78945,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(accountAsString);

                fileStream.Write(bytes, 0, bytes.Length);
            }
        }

        static void CreateFileWithStreamWriter()
        {
            var pathFile = "AccountsExported.csv";

            using (var fileStream = new FileStream(pathFile, FileMode.Create))
            using (var writer = new StreamWriter(fileStream))
            {
                writer.Write("456,678123,456.0,Pedro");
            }
        }

          
    }
}