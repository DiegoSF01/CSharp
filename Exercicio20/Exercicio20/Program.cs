using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new string[5];
            double[] vendas_valor = new double[5];
            double[] comissao = new double[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Qual o nome do vendedor: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Qual o valor vendido pelo vendedor: ");
                vendas_valor[i] = double.Parse(Console.ReadLine());

                if (vendas_valor[i] <= 20000)
                {
                    comissao[i] = vendas_valor[i] * 0.05;
                }
                else if (vendas_valor[i] <= 40000)
                {
                    comissao[i] = vendas_valor[i] * 0.06;
                }
                else
                {
                    comissao[i] = (vendas_valor[i] * 0.07);
                }

                Console.Clear();
            }

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Informações do vendedor" + (i+1) + ": ");
                Console.WriteLine("");
                Console.WriteLine(nome[i]);
                Console.WriteLine(vendas_valor[i]);
                Console.WriteLine(comissao[i]);
            }

            Console.ReadKey();

        }
    }
}
