using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a quantidade de números: ");
            int numeros = int.Parse(Console.ReadLine());

            double menor = double.MaxValue;
            double maior = double.MinValue;
            double[] numero_escolhido = new double[numeros];

            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine("Digite o número: ");
                numero_escolhido[i] = double.Parse(Console.ReadLine());

                if (numero_escolhido[i] < menor)
                {
                    menor = numero_escolhido[i];
                }

                if (numero_escolhido[i] > maior)
                {
                    maior = numero_escolhido[i];
                }
            }

            Console.Write("Números digitados: ");

            for (int j = 0;j < numeros; j++)
            {
                Console.Write(" " + numero_escolhido[j]);
            }

            Console.WriteLine("");
            Console.WriteLine("O menor número digitado foi: " + menor);
            Console.WriteLine("O maior número digitado foi: " + maior);

            Console.ReadKey();

        }
    }
}
