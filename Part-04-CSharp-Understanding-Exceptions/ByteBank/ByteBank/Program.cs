using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LoadAccounts();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN.");
            }

            Console.ReadLine();
        }

        private static void LoadAccounts()
        {
            using (FileReader file = new FileReader("test.txt"))
            {
                file.ReadNextLine();
            }
            
            //FileReader file = null;
            //try
            //{
            //    file = new FileReader("accounts.txt");
            //    file.ReadNextLine();
            //    file.ReadNextLine();
            //    file.ReadNextLine();                
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("IOException was catched!");
            //}
            //finally
            //{
            //    if (file != null)
            //    {
            //        file.Close();
            //    }
            //}
        }

        private static void InnerException()
        {
            try
            {
                CheckingAccount account1 = new CheckingAccount(123, 123456);
                CheckingAccount account2 = new CheckingAccount(234, 234567);

                //account1.Tranfer(10000, account2);
                account1.Withdraw(1000);
            }
            catch (FinanceOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("INNER EXCEPTION informations: ");
            }
        }
    }
}
