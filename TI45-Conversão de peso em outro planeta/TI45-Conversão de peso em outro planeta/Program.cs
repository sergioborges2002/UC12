using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Conversão_de_peso_em_outro_planeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, peso_ot_planeta,op;
            Console.WriteLine("O peso em outro planeta");
            Console.WriteLine("Digite seu peso em kg");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("# | Gravidade Relatviva | Planeta");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1          0,37           Mercúrio");
            Console.WriteLine("2          0,88           Vênus");
            Console.WriteLine("3          0,38           Marte");
            Console.WriteLine("4          2,64           Júpiter");
            Console.WriteLine("5          1,15           Saturno");
            Console.WriteLine("6          1,17           Urano");
            Console.WriteLine("----------------------------------");
            op = double.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    peso_ot_planeta = peso * 0.37;
                    Console.WriteLine("O seu peso em Mercúrio seria "+Math.Round(peso_ot_planeta,2)+" kg");
                    break;
                    case 2:
                    peso_ot_planeta = peso * 0.88;
                    Console.WriteLine("O seu peso em Vênus seria " + Math.Round(peso_ot_planeta, 2) + " kg");
                    break;
                case 3:
                    peso_ot_planeta = peso * 0.38;
                    Console.WriteLine("O seu peso em Marte seria " + Math.Round(peso_ot_planeta, 2) + " kg");
                    break;
                case 4:
                    peso_ot_planeta = peso * 2.64;
                    Console.WriteLine("O seu peso em Júpiter seria " + Math.Round(peso_ot_planeta, 2) + " kg");
                    break;
                case 5:
                    peso_ot_planeta = peso * 1.15;
                    Console.WriteLine("O seu peso em Saturno seria " + Math.Round(peso_ot_planeta, 2) + " kg");
                    break;
                case 6:
                    peso_ot_planeta = peso * 1.17;
                    Console.WriteLine("O seu peso em Urano seria " + Math.Round(peso_ot_planeta, 2) + " kg");
                    break;
                
                default:
                    Console.WriteLine("Opção errada");
                    Console.WriteLine("Digite qualquer tecla para sair...");
                    break;
            }
            Console.ReadKey();  




        }
    }
}
