using ByteBank.Employees;
using ByteBank.Systems;
using System;
using System.Collections.Generic;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalculateBonification();
            UseSystem();
            Console.ReadLine();
        }

        public static void UseSystem()
        {
            InternalSystem internalSystem = new InternalSystem();
            
            Director roberta = new Director("159.753.398-04");
            roberta.Name = "Roberta";
            roberta.Password = "123";

            AccountManager camila = new AccountManager("326.985.628-89");
            camila.Name = "Camila";
            camila.Password = "abc";

            ComercialPartner partner = new ComercialPartner();
            partner.Password = "123456";

            internalSystem.LogOn(roberta, "123");
            internalSystem.LogOn(camila, "abc");
            internalSystem.LogOn(partner, "123456");
        }

        public static void CalculateBonification()
        {
            BonusManager bonusManager = new BonusManager();

            Employee pedro = new Designer("833.222.048-39");
            pedro.Name = "Pedro";

            Employee roberta = new Director("159.753.398-04");
            roberta.Name = "Roberta";

            Employee igor = new Assistant("981.198.778-53");
            igor.Name = "Igor";

            Employee camila = new AccountManager("326.985.628-89");
            camila.Name = "Camila";

            bonusManager.Registrate(pedro);
            bonusManager.Registrate(roberta);
            bonusManager.Registrate(igor);
            bonusManager.Registrate(camila);

            Console.WriteLine("Total bonification in the month: "+bonusManager.GetTotalBonification());
        }
    }
}
