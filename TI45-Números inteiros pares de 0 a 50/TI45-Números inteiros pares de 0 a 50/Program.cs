using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Números_inteiros_pares_de_0_a_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Números pares de 0 a 50");
            //for (i = 0; i <= 50; i++)
            //{
            //    if (i % 2 == 0) Console.WriteLine(i);
            //}
            for(i = 0; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
