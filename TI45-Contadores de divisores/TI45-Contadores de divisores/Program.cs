using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Contadores_de_divisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n,cont=0;
            Console.WriteLine("1 número positivo e seus divisores");
            Console.WriteLine("Digite 1 nº positivo");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Divisores de "+n+":");
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                if (n%i == 0)
                {
                    Console.Write(i+" ");
                    cont++;
                }
            }
            Console.WriteLine("\n\n"+n+" tem "+cont+" divisores.");
            Console.ReadKey();
        }
    }
}
