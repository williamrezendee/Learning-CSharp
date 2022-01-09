using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3._1_ConsultingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Month> months = new List<Month>
            {
                new Month("Janeiro",31),
                new Month("Fevereiro",28),
                new Month("Março",31),
                new Month("Abril",30),
                new Month("Maio",31),
                new Month("Junho",30),
                new Month("Julho",31),
                new Month("Agosto",31),
                new Month("Setembro",30),
                new Month("Outubro",31),
                new Month("Novembro",30),
                new Month("Dezembro",31)
            };

            // Pegar todos os meses de 31 dias, ordenar em ordem alfabética e colocá-los em caixa alta
            IEnumerable<string> query = months
                .Where(m => m.Days == 31)
                .OrderBy(m => m.Name)
                .Select(m => m.Name.ToUpper());

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Pegar o primeiro trimestre
            var query1 = months.Take(3);
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Pegar os meses depois do primeiro trimestre
            var query2 = months.Skip(3);
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Pegar os meses do terceiro trimestre
            var query3 = months.Skip(6).Take(3);
            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Pegar os meses até que o mês comece com a letra 'S'
            var query4 = months.TakeWhile(m => !m.Name.StartsWith("S"));
            foreach (var item in query4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Pular os meses até que o mês comece com a letra 'S'
            var query5 = months.SkipWhile(m => !m.Name.StartsWith("S"));
            foreach (var item in query5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

    class Month //: IComparable
    {
        public string Name { get; private set; }
        public int Days { get; private set; }
        public Month(string name, int days)
        {
            Name = name;
            Days = days;
        }

        public override string ToString()
        {
            return Name + " - " + Days;
        }

        //public int CompareTo(object obj)
        //{
        //    Month other = obj as Month;
        //    return Name.CompareTo(other.Name);
        //}
    }
}
