using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Quadrado_do_número_impresso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,num;
            Console.WriteLine("Quadrado do número impresso");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite "+i+ "º número");
                num=int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(num + "² = " + Math.Pow(num, 2));
                Console.WriteLine();
     


            }
            Console.WriteLine("Digite qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
