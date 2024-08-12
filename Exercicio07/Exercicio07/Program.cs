using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a operação a ser utilizada Mais(+) Menos(-) Vezez(x) Dividir(/): ");
            string operacao = Console.ReadLine();

            if (operacao == "+")
            {
                double resultado = numero1 + numero2;

                Console.WriteLine(resultado);
            }
            else if (operacao == "-")
            {
                double resultado = (numero1 - numero2);

                Console.WriteLine(resultado);
            }
            else if(operacao == "x")
            {
                double resultado = numero1 * numero2;

                Console.WriteLine(resultado);
            }
            else
            {
                double resultado = numero1 / numero2;

                Console.WriteLine(resultado);
            }

            Console.ReadKey();
        }
    }
}
