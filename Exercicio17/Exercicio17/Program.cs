using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double despesa = 0;
            double valor = 0;

            String iniciar;

            do
            {
                Console.WriteLine("Qual o valor da despesa: ");
                valor = double.Parse(Console.ReadLine());

                despesa = despesa + valor;

                Console.WriteLine("Qual a descriçao da despesa: ");
                string descricao = Console.ReadLine();

                Console.WriteLine("Continuar o programa (S/N): ");
                iniciar = Console.ReadLine().ToUpper();

                Console.Clear();

            }
            while (iniciar == "S");

            Console.WriteLine("Possui quantas pessoas na casa: ");
            int pessoas = int.Parse(Console.ReadLine());

            Console.Clear();

            double gasto_pessoa = despesa / pessoas;

            Console.WriteLine("A despesa total foi de: R$" + despesa);
            Console.WriteLine("E a quantia gasta por pessoa foi de: R$" + gasto_pessoa);

            Console.ReadKey();

        }
    }
}
