using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual sua idade: ");
            int idade_ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos de trabalho possui: ");
            int idade_trabalho = int.Parse(Console.ReadLine());

            if (idade_ano >= 65 ||  idade_trabalho >= 30 || idade_ano >= 60 && idade_trabalho >= 25)
            {
                Console.WriteLine("Tem direito a aposentadoria!");
            }
            else
            {
                Console.WriteLine("Não tem direito a aposentadoria!");
            }

            Console.ReadKey();


        }
    }
}
