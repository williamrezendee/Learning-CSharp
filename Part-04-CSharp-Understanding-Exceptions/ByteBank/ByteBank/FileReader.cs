using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class FileReader : IDisposable
    {
        public string File { get; }

        public FileReader(string file)
        {
            File = file;
            //throw new FileNotFoundException();
            Console.WriteLine("Opening file: "+file);
        }

        public string ReadNextLine()
        {
            Console.WriteLine("Reading line...");
            throw new IOException();
            return "File's line";
        }

        public void Dispose()
        {
            Console.WriteLine("Closing file.");
        }
    }
}
