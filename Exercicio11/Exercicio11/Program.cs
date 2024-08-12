using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual vai ser a operação (+ (mais), - (menos), * (vezes), / (divisão): ");
            string operacao = Console.ReadLine();
            
            switch (operacao)
            {
                case "+":
                    Console.WriteLine("A soma é: " + (numero1 + numero2));
                    break;

                case "-":
                    Console.WriteLine("A subtração é: " + (numero2 - numero1));
                    break;

                case "*":
                    Console.WriteLine("A multiplicação é: " + (numero1 * numero2));
                    break;

                case "/":
                    Console.WriteLine("A divisão é: " + (numero1 / numero2));
                    break;
            }

            Console.ReadKey();

        }
    }
}
