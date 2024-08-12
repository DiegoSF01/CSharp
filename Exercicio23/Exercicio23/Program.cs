using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor de A: ");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de B: ");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de C: ");
            double C = double.Parse(Console.ReadLine());

            bhaskara(A, B, C);

            Console.ReadKey();
        }

        static void bhaskara(double A, double B, double C)
        {
            double Delta = B * B - 4 * A * C;
            double Raiz_Delta = Math.Sqrt(Delta);
            double Resultado1 = ((B * -1) + Raiz_Delta) / (2 * A);
            double Resultado2 = ((B * -1) - Raiz_Delta) / (2 * A);

            Console.WriteLine("O valor de Delta: " + Delta);
            Console.WriteLine("O valor da Raiz de Delta: " + Raiz_Delta);
            Console.WriteLine("O resultado de X1: " + Resultado1);
            Console.WriteLine("O resultado de X2: " + Resultado2);    
        }
    }
}
