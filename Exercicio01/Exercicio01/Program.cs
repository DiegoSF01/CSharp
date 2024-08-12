using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inicio do calculo TBM
            double TBM;

            Console.WriteLine("Qual seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Qual seu peso em KG: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura em CM: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Você é homem ou mulher (1 = Homem) (0 = Mulher): ");
            int sexo = int.Parse(Console.ReadLine());

            if (sexo <= 1)
            {
                TBM = 66 + (13.8 * peso) + (5 * altura) - (6.8 * idade);
            }
            else
            {
                TBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * idade);
            }

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu peso é: " + peso + "kg");
            Console.WriteLine("Sua altura é: " + altura + "cm");
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("E seu TBM é de: " + TBM + "kcal/dia");
            //Fim do calculo TBM

        }
    }
}
