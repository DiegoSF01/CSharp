using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor da diária do hotel: R$");
            double Diaria = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de adultos: ");
            int Adultos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de crianças: ");
            int Criancas = int.Parse(Console.ReadLine());

            double Diaria_a_Pagar = (Diaria * Adultos) + (Diaria/2 * Criancas);

            Console.WriteLine("O valor por dia da família será: R$" + Diaria_a_Pagar.ToString("C"));

            Console.WriteLine("");

            Console.WriteLine("Informe o número de dias de hospedagem: ");
            int Dias = int.Parse(Console.ReadLine());

            double Valor_da_Hospedagem = Diaria_a_Pagar * Dias;

            Console.WriteLine("O valor total da hospedagem é de: R$" + Valor_da_Hospedagem.ToString("C"));

            Console.WriteLine("");

            Console.WriteLine("Informe o número de parcelas: ");
            int Parcelas = int.Parse(Console.ReadLine());

            double Valor_cada_Parcela = Valor_da_Hospedagem / Parcelas;

            Console.WriteLine("O valor de cada parcela é de: R$" + Valor_cada_Parcela.ToString("C"));

            Console.ReadKey();

        }
    }
}
