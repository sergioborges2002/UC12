using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, total;
            Console.WriteLine("Restauarante Bem Bão - TI45");
            Console.WriteLine("Valor: R$ 42,00 - kg");
            Console.WriteLine("Digite o peso da porção:");
            peso = double.Parse(Console.ReadLine());
            total = peso * 42;
            Console.WriteLine("Total a pagar: R$ " + Math.Round(total, 2));
            Console.ReadKey();
        }
    }
}
