using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOnModels
{
    class Program
    {
        static void Main(string[] args)
        {
            Course csharpCollections = new Course("Collections", "Marcelo Oliveira");
            csharpCollections.Add(new Lesson("Working with Lists", 21));
            csharpCollections.Add(new Lesson("Creating a lesson", 20));
            csharpCollections.Add(new Lesson("Modeling with Collections", 24));

            // Instanciando 3 alunos com suas respectivas matrículas
            // Vanessa Tonini - 34672
            // Ana Losnak - 56179
            // Rafael Nercessian - 17645

            Student vanessa = new Student("Vanessa Tonini", 34672);
            Student ana = new Student("Ana Losnak", 56179);
            Student rafael = new Student("Rafael Nercessian", 17645);

            csharpCollections.Enroll(vanessa);
            csharpCollections.Enroll(ana);
            csharpCollections.Enroll(rafael);

            Console.WriteLine("Printing enrolled students");
            foreach (var student in csharpCollections.Students)
            {
                Console.WriteLine(student);
            }

            // Verificar se um determinado aluno está matriculado
            Console.WriteLine($"The student {nameof(vanessa)} is enrolled?");
            Console.WriteLine(csharpCollections.IsEnrolled(vanessa));

            // Testando outra instância com os mesmos dados
            Student tonini = new Student("Vanessa Tonini", 34672);
            Console.WriteLine($"The student {nameof(tonini)} is enrolled?");
            Console.WriteLine(csharpCollections.IsEnrolled(tonini));

            Console.WriteLine($"{nameof(vanessa)} == {nameof(tonini)}?");
            Console.WriteLine(vanessa == tonini);

            Console.WriteLine($"{nameof(vanessa)} is equals to {nameof(tonini)}?");
            Console.WriteLine(vanessa.Equals(tonini));

            


        }
    }
}
