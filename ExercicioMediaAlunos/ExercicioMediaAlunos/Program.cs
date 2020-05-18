using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a 1a nota do aluno:");
            var nota1 = Console.ReadLine();
            Console.WriteLine("Entre com a 2a nota do aluno:");
            var nota2 = Console.ReadLine();

            CalcularMediaAlunos<string> calcularMediaAlunos = new CalcularMediaAlunos<string>();
            object obj2 = new Obj();

            calcularMediaAlunos.calcularMedia(nota1, nota2);

            Console.WriteLine();

            Console.ReadLine();
            

            

        }
        public class Obj
        {

        }
    }
}
