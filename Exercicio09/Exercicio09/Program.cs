using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a média do aluno: ");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a presença do aluno em %: ");
            double presenca = double.Parse(Console.ReadLine());

            if (media >= 7 && presenca >= 75)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media < 7 && media >= 4 || media >= 7 && presenca < 75)
            {
                Console.WriteLine("Recuperação!");
            }
            else
            {
                Console.WriteLine("Retido!");
            }

            Console.ReadKey();

        }
    }
}
