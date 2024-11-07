using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Quadrado_dos_números_de_1_a_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("O Quadrado dos números no intervalo fechado de 1 a 20");
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine(i+"² = "+Math.Pow(i,2));
            }
            Console.ReadKey();
        }
    }
}
