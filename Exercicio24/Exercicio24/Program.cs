using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
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

            Console.WriteLine("O valor de Delta: " + bhaskaraDelta(A,B,C));
            Console.WriteLine("O valor da Raiz de Delta: " + bhaskaraRaiz_Delta(A,B,C));
            Console.WriteLine("O resultado de X1: " + bhaskaraX1(A,B,C));
            Console.WriteLine("O resultado de X2: " + bhaskaraX2(A,B,C));

            Console.ReadKey();
        }

        static double bhaskaraDelta(double A, double B, double C)
        {
            return B * B - 4 * A * C;
        }

        static double bhaskaraRaiz_Delta(double A, double B, double C)
        {
            return Math.Sqrt(B * B - 4 * A * C);
        }

        static double bhaskaraX1(double A, double B, double C)
        {

            return ((B * -1) + Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
            
        }

        static double bhaskaraX2(double A, double B, double C)
        {
            return ((B * -1) - Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
        }
    }
}
