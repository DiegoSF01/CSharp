using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1, 2, 3, 4, 5 ou 6: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {

                int cont = 1;

                while (cont <= 100)
                {

                    Console.WriteLine(cont);
                    cont++;

                }
            }

            else if (escolha == 2)
            {

                int cont = 100;

                while (cont > 1)
                {
                    Console.WriteLine(cont);
                    cont--;
                }

            }

            else if (escolha == 3)
            {
                int cont = 0;

                while (cont <= 100)
                {

                    Console.WriteLine(cont);
                    cont += 2;

                }

            }

            else if (escolha == 4)
            {
                Console.WriteLine("Informe um número para ser multiplicado até o resultado for 100 ou perto: ");
                double numero = double.Parse(Console.ReadLine());

                double cont = numero;

                while (cont <= 100)
                {
                    Console.WriteLine(cont);
                    cont += numero;
                }
            }

            else if (escolha == 5)
            {

                Console.WriteLine("Escolha entre pares(1) ou ímpares(0): ");
                int escolha5 = int.Parse(Console.ReadLine());

                int cont = escolha5;

                while (cont <= 20)
                {

                    Console.WriteLine(cont);
                    cont += 2;

                }

            }

            else if (escolha == 6)
            {

                int cont = 1;

                Console.WriteLine("Digite um número: ");
                double numero = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de vezes: ");
                int vezes = int.Parse(Console.ReadLine());

                while (cont <= vezes)
                {
                    Console.WriteLine(numero + "X" + cont + "=" + (numero * cont));
                    cont++;

                }

            }

            else
            {
                Console.WriteLine("Ops! Algo deu errado! Tente novamente.");
            }

            Console.ReadKey();

        }
    }
}
