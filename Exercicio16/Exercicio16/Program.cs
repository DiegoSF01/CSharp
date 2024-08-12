using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int DS = 5;
            int E = 5;
            int M = 5;
            int A = 5;
            Console.WriteLine("Deseja começar: ");
            string s = Console.ReadLine().ToUpper();

            Console.Clear();

            while (s == "S")

            {

                Console.Clear();

                Console.WriteLine("(DS) desenvolvimento de sistemas, (M) Mecatronica (E) Edificaçeõs (A) Administração ");
                string curso = Console.ReadLine().ToUpper();

                Console.Clear();

                if
                (curso == "DS" && DS > 0)
                {
                    Console.WriteLine("Você foi cadastrado em desenvolvimento de sistemas");
                    DS = DS - 1;
                }
                else if
                   (curso == "E" && E > 0)
                {
                    Console.WriteLine("Você foi cadastrado em Edificaçeõs");
                    E = E - 1;
                }
                else if (curso == "M" && M > 0)
                {
                    Console.WriteLine("Você foi cadastrado em  Mecatronica");
                    M = M - 1;
                }

                else if (curso == "A" && A > 0)
                {
                    Console.WriteLine("Você foi cadastrado em  Administração");
                    A = A - 1;
                }
                else
                {
                    Console.WriteLine("Não há mais vagas desponiveis");
                }

                Console.WriteLine("O numero de vagas restantes DS= " + DS + " E= " + E + " M= " + M + " A " + A);

                Console.WriteLine("Deseja continuar com o programa? ");
                s = Console.ReadLine().ToUpper();

            }

            Console.ReadKey();

        }
    }
}
