using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Estrutura_de_Múltipla_escolha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Estrutura de Múltipla escolha");
            Console.WriteLine("Digite 1 ou 2");
            op=int.Parse(Console.ReadLine());
            switch (op){
                case 1:
                    Console.WriteLine("VB/Delphi");
                    break;
                    case 2:
                    Console.WriteLine("C/C++/C#,Java");
                    break;
                default:
                    Console.WriteLine("Erro! Não existe essa opção!");
                    Console.WriteLine("Digite qualquer tecla para sair do programa...");
                    Console.ReadKey();
                    break;

            }
            Console.ReadKey();

        }
    }
}
