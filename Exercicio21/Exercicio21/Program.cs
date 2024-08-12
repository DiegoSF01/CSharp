using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            double[] IMC = new double[5];
            double acima_peso = 0;

            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Qual o nome da pessoa: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Qual o peso em kilos da pessoa: ");
                peso[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual a altura em metros da pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());

                IMC[i] = peso[i] / (altura[i] * altura[i]);

                Console.Clear();
            }

            for (int i = 0; i <= 4; i++)
            {
                if (IMC[i] <= 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (IMC[i] <= 24.9)
                {
                    Console.WriteLine("Peso ideal (parabéns)");
                }
                else if (IMC[i] <= 29.9)
                {
                    Console.WriteLine("Levemente acima do peso");
                    acima_peso++;
                }
                else if (IMC[i] <= 34.9)
                {
                    Console.WriteLine("Obesidade grau I");
                    acima_peso++;
                }
                else if (IMC[i] <= 39.9)
                {
                    Console.WriteLine("Obesidade grau II (severa)");
                    acima_peso++;
                }
                else
                {
                    Console.WriteLine("Obesidade grau III (mórbida)");
                    acima_peso++;
                }

                Console.Clear();
            }

            acima_peso = acima_peso / 5 * 100;

            Console.WriteLine("A porcentagem de pessoas acima do peso é de %" +  acima_peso);

            Console.ReadKey();

        }
    }
}
