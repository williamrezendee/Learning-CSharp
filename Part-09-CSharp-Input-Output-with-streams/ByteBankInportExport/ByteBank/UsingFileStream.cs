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
        static void UsingFileStreamDirectly()
        {
            var fileAddress = "accounts.txt";

            using (var fileStream = new FileStream(fileAddress, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1Kb
                var readedBytes = -1;

                while (readedBytes != 0)
                {
                    readedBytes = fileStream.Read(buffer, 0, 1024);
                    WriteBufferOnScreen(buffer, readedBytes);
                }
            }
        }

        static void WriteBufferOnScreen(byte[] buffer, int readedBytes)
        {
            var utf8 = Encoding.Default;
            var text = utf8.GetString(buffer, 0, readedBytes);
            Console.Write(text);

            //foreach (var myByte in buffer)
            //{
            //    Console.Write(myByte);
            //    Console.Write(" ");
            //}
        }
    }
}
