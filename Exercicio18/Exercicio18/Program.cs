using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double conta_cliente = 0;

            String iniciar;

            do
            {

                Console.WriteLine("Quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Valor unitário do produto: ");
                double valor = double.Parse(Console.ReadLine());

                valor = valor * quantidade;

                Console.WriteLine("Qual o tipo de operação ( (V)Venda / (D)Devolução ): ");
                string operacao = Console.ReadLine().ToUpper();

                if (operacao == "V")
                {

                    conta_cliente = conta_cliente + valor;

                }
                else
                {

                    conta_cliente = conta_cliente - valor;

                }

                Console.Clear();

                Console.WriteLine("Deseja continuar o programa (S/N): ");
                iniciar = Console.ReadLine().ToUpper();

                Console.Clear();

            }
            while (iniciar == "S");

            Console.WriteLine("Saldo do cliente: R$" +  conta_cliente);

            if (conta_cliente > 0)
            {

                Console.WriteLine("O cliente devera pagar: R$" + conta_cliente);

            }
            else
            {

                conta_cliente = conta_cliente * -1;

                Console.WriteLine("O cliente devera receber: R$" + conta_cliente);

            }

            Console.ReadKey();

        }
    }
}
