using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double altura, base0, diagonal_maior, diagonal_menor, base1;

            Console.WriteLine("Escolha entre ");
            Console.WriteLine("* Quadrado (Q)");
            Console.WriteLine("* Retângulo (R)");
            Console.WriteLine("* Trapézio (T)");
            Console.WriteLine("* Losango (L)");
            Console.WriteLine("para calcular a área: ");
            string forma_geometrica = Console.ReadLine().ToUpper();

            switch (forma_geometrica)
            {
                case "Q":
                    Console.WriteLine("Quanto é a altura: ");
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quanto é a base: ");
                    base0 = double.Parse(Console.ReadLine());

                    Console.WriteLine("A área é de: " +  altura * base0);
                    break;

                case "R":
                    Console.WriteLine("Quanto é a altura: ");
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quanto é a base: ");
                    base0 = double.Parse(Console.ReadLine());

                    Console.WriteLine("A área é de: " + altura * base0);
                    break;

                case "T":
                    Console.WriteLine("Quanto é a altura: ");
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quanto é a base 1: ");
                    base0 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quanto é a base 2: ");
                    base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("A área é de: " + (base0 * base1) * altura / 2);
                    break;

                case "L":
                    Console.WriteLine("Quanto é a diagonal maior: ");
                    diagonal_maior = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quanto é a diagonal menor: ");
                    diagonal_menor = double.Parse(Console.ReadLine());

                    Console.WriteLine("A área é de: " + (diagonal_maior * diagonal_menor) / 2);
                    break;
            }

            Console.ReadKey();

        }
    }
}
