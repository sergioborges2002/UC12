using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Quantos_dias_no_Mês
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;

            Console.WriteLine("Quantos dias no Mês");
            Console.WriteLine("Digite o Mês do ano");
            mes=int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
            Console.WriteLine("O Mês "+mes+" tem 31 dias");
                        break;
                case 2:
                    Console.WriteLine("O Mês "+mes+ " tem 28 dias ou 29 dias");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("O Mês tem 30 dias");
                    break;
                default:
                    Console.WriteLine("Nº de mês inválido");
                    Console.WriteLine("Digite qualquer tecla para sair do programa");
                    Console.ReadKey();
                    break;

            }
            Console.ReadKey();

        }
    }
}
