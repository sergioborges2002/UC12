using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Números_de_50_a_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Números de 50 a 0");
            for( i = 50; i >= 0; i-- )
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
