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
        static void BinaryWrite()
        {
            using (var fs = new FileStream("account.txt", FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(456); // Agency Number
                writer.Write(567890); // Account Number
                writer.Write(4000.50); // Balance
                writer.Write("William"); // Holder's name
            }
        }

        static void BinaryRead()
        {
            using (var fs = new FileStream("account.txt", FileMode.Open))
            using (var reader = new BinaryReader(fs))
            {
                var agency = reader.ReadInt32();
                var number = reader.ReadInt32();
                var balance = reader.ReadDouble();
                var name = reader.ReadString();

                Console.WriteLine($"{agency},{number},{name},{balance}");
            }
        }
    }
}
