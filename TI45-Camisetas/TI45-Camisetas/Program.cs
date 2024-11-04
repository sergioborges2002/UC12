using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Camisetas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, m, g, gg, total;
            Console.WriteLine("Pedido de Camisetas");
            Console.WriteLine("Digite o nº de camisetas P:");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nº de camisetas M:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nº de camisetas G:");
            g = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nº de camisetas GG:");
            gg = int.Parse(Console.ReadLine());
            total = p * 20 + m * 22 + g * 25 + gg * 30;
            Console.WriteLine("Total do Pedido: R$ " + total);
            Console.WriteLine("Digite uma tecla para sair...");
            Console.ReadKey();
        }
    }
}