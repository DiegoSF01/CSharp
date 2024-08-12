using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[] meses = { "JAN", "FEV", "MAR", "ABR", "MAI", "JUN", "JUL", "AGO", "SET", "OUT", "NOV", "DEZ" };

            Console.WriteLine("Digite o número do mês: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês escolhido foi: " + meses[i - 1]);

            Console.ReadKey();

        }
    }
}
