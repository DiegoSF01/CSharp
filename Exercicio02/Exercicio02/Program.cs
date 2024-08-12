using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o valor do combustível utilizado: ");
            double combustivel_valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a distância percorrida em Km: ");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos Km o veiculo faz por litro: ");
            double veiculo = double.Parse(Console.ReadLine());

            double combustivel_a_utilizar = distancia / veiculo;
            double gasto_em_combustivel = combustivel_a_utilizar * combustivel_valor;

            Console.WriteLine("Será utilizado " + combustivel_a_utilizar + " Litros");
            Console.WriteLine("Será gasto R$" + gasto_em_combustivel);

        }
    }
}
