using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Tabela_de_combustíveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op;
            int litros;
            double preco;
            Console.WriteLine("Tabela de preços de combustíveis");
            Console.WriteLine("A - Álcool - R$ 3.75");
            Console.WriteLine("D - Diesel - R$ 5.90");
            Console.WriteLine("G - Gasolina - R$ 5.55");
            Console.WriteLine("-------------------------------");
            op = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de litros");
            litros = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            switch (op)
            {
                case "A":
                    preco = litros * 3.75;
                    Console.WriteLine("O preço a ser pago é R$ " + Math.Round(preco,2));
                    break;
                case "D":
                    preco = litros * 5.90;
                    Console.WriteLine("O preço a ser pago é R$ " + Math.Round(preco, 2));
                    break;
                case "G":
                    preco = litros * 5.55;
                    Console.WriteLine("O preço a ser pago é R$ " + Math.Round(preco, 2));
                    break;
                default: Console.WriteLine("Opçao errada");
                    Console.WriteLine("Digite qualquer tecla para sair...");
                    break;
                
                   
            }
            
           Console.ReadKey();

        }
    }
}
