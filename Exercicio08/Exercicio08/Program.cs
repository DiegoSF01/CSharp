using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual se peso em kg: ");
            double kg = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = kg / (altura * altura);

            if (IMC < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso!");
            }
            else if (IMC <= 18.4)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if (IMC <= 24.9)
            {
                Console.WriteLine("Peso normal!");
            }
            else if (IMC <= 29.9)
            {
                Console.WriteLine("Acima do peso!");
            }
            else if (IMC <= 34.9)
            {
                Console.WriteLine("Obesidade grau 1!");
            }
            else if (IMC <= 40)
            {
                Console.WriteLine("Obesidade grau 2!");
            }
            else if (IMC > 40)
            {
                Console.WriteLine("Obesidade grau 3!");
            }
            else
            {
                Console.WriteLine("ERRO! Tente novamente!");
            }

            Console.ReadKey();
        }
    }
}
