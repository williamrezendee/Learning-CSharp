using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSetsPower
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sets == Conjuntos
            // 1. Não permite duplicidade de itens
            // 2. Os itens não são mantidos, necessariamente, na mesma ordem que são adicionados

            // Declarando Sets de alunos
            ISet<string> alunos = new HashSet<string>();
            // Adicionando os alunos: Vanessa, Ana e Rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");
            // Imprimindo com Console.WriteLine
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            // Adicionando mais alunos
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(", ", alunos));
            // Vamos testar a ordem por meio da remoção de Ana e inclusão de Marcelo
            alunos.Remove("Ana Losnak");
            Console.WriteLine(string.Join(", ", alunos));
            alunos.Add("Marcelo Oliveira");

            // Imprimindo novamente
            Console.WriteLine(string.Join(", ", alunos));

            // Testando a regra de não duplicidade de elementos
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(", ", alunos));

            // Ordenando o conjunto através do método Sort()
            //alunos.Sort();
            // Um conjunto do tipo ISet<> não possui uma definição para o método Sort()
            // Para tanto, é preciso fazer uma cópia do mesmo em uma List<>

            List<string> alunosEmLista = new List<string>(alunos);
            // Ordenando a lista
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(", ",alunosEmLista));
            

        }
    }
}
