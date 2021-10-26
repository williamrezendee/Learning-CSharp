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
        static void UseInputStream()
        {
            using (var fs = Console.OpenStandardInput())
            using (var fs1 = new FileStream("ConsoleInput.txt", FileMode.Create))
            {
                var buffer = new byte[1024]; // 1Kb

                while (true)
                {
                    var bytesReaded = fs.Read(buffer, 0, buffer.Length);
                    fs1.Write(buffer, 0, bytesReaded);
                    fs1.Flush();
                    Console.WriteLine($"Bytes readed of the Console: {bytesReaded}");
                }
            }
        }
    }
}
