using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario_bruto = 0;

            Console.Write("Qual a forma de contratação ( Assalariado (A), Comissionado (C), Horista (H) ): ");
            string contratacao = Console.ReadLine().ToUpper();

            switch (contratacao)
            {
                case "A":
                    Console.WriteLine("Forma de contratação: ASSALARIADO");

                    Console.Write("Qual seu salário bruto: R$");
                    double salario = double.Parse(Console.ReadLine());

                    Console.Write("Qual o desconto: R$");
                    double desconto = double.Parse(Console.ReadLine());

                    salario_bruto = salario - desconto;
                    break;

                case "C":
                    Console.WriteLine("Forma de contratação: COMISSIONADO");

                    Console.Write("Quantidade de peças vendidas: ");
                    double pecas_vendidas = double.Parse(Console.ReadLine());

                    Console.Write("Qual a comissão por peça: ");
                    double comissao_peca = double.Parse(Console.ReadLine());

                    salario_bruto = pecas_vendidas * comissao_peca;
                    break;

                case "H":
                    Console.WriteLine("Forma de contratação: HORISTA");

                    Console.Write("Qual o valor da hora: R$");
                    double valor_hora = double.Parse(Console.ReadLine());

                    Console.Write("Quantas horas foram trabalhadas: ");
                    double horas_trabalhadas = double.Parse(Console.ReadLine());

                    salario_bruto = horas_trabalhadas * valor_hora;
                    break;
            }

            if (salario_bruto <= 2000)
            {
                Console.WriteLine("O valor do IR é de: R$" + salario_bruto * 0.075);
                double IR = double.Parse(Console.ReadLine());

                Console.WriteLine("Seu salário líquido é de: R$" + (salario_bruto - IR));
            }
            else if (salario_bruto <= 4000)
            {
                Console.WriteLine("O valor do IR é de: R$" + salario_bruto * 0.12);
                double IR = double.Parse(Console.ReadLine());

                Console.WriteLine("Seu salário líquido é de: R$" + (salario_bruto - IR));
            }
            else
            {
                Console.WriteLine("O valor do IR é de: R$" + salario_bruto * 0.15);
                double IR = double.Parse(Console.ReadLine());

                Console.WriteLine("Seu salário é de: R$" + (salario_bruto - IR));
            }

            Console.ReadKey();

        }
    }
}
