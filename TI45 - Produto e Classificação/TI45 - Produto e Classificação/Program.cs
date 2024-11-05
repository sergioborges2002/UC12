using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Produto_e_Classificação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod;
            Console.WriteLine("Código do produto e sua classificação");
            Console.WriteLine("Digite o código do produto");
            cod = int.Parse(Console.ReadLine());
            switch (cod) {
                case 1:
                    Console.WriteLine("Alimento não-perecível");
                        break;
                case 2:
                case 3:
                    case 4:
                    Console.WriteLine("Alimento perecível");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Vestuário");
                    break;
                    case 7:
                    Console.WriteLine("Higiene Pessoal");
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    case 14:
                    case 15:
                    Console.WriteLine("Limpeza e Utensílios Domésticos");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    Console.WriteLine("Digite qualquer tecla para sair");
                    Console.ReadKey();
                    break;



            }
            Console.ReadKey();
        }
    }
}
