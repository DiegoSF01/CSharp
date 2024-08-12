using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idada de meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade de dias ");
            int dias = int.Parse(Console.ReadLine());

            int dias_vividos = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("Dias vividos: " + dias_vividos);

        }
    }
}
