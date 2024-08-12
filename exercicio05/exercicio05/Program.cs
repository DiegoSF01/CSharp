using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual seu salário bruto: ");
            uint Salario_Bruto = uint.Parse(Console.ReadLine());

            Console.WriteLine("Quanto de vale alimentação: ");
            uint Vale_Alimentacao = uint.Parse(Console.ReadLine());

            Console.WriteLine("Quantos filhos você possui: ");
            uint Filhos = uint.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor por filho: ");
            uint Valor_Filhos = uint.Parse(Console.ReadLine());

            Console.WriteLine("Numeros de horas extras: ");
            uint Horas_Extras = uint.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora: ");
            uint Valor_Hora = uint.Parse(Console.ReadLine());

            Console.WriteLine("Valor do INSS: ");
            uint INSS = uint.Parse(Console.ReadLine());

            Console.WriteLine("Valor do IRPF: ");
            uint IRPF = uint.Parse(Console.ReadLine());

            uint Salario_Liquido = Salario_Bruto + Vale_Alimentacao + (Filhos * Valor_Filhos) + 
                (Horas_Extras * Valor_Hora) - INSS - IRPF;

            Console.WriteLine("Seu salário liquido é de: R$" + Salario_Liquido);

            Console.ReadKey();

        }
    }
}
