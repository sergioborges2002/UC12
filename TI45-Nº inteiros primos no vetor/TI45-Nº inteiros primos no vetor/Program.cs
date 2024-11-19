using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Nº_inteiros_primos_no_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, ii, primo = 0;
            int[] v = new int[10];
            Random rnd = new Random();

            Console.WriteLine(" vetor de 10 valores ");

            for (i = 1; i < v.Length; i++)
            {
                v[i] = rnd.Next(1, 20);
                Console.Write(" " + v[i] + " ");
            }
            Console.WriteLine("\n valores primos e sua posição no vetor ");

            for (i = 0; i < v.Length; i++)
            {

                for (ii = 1; ii <= v[i]; ii++)
                {
                    if (v[i] % ii == 0)
                    {
                        primo++;
                    }
                }
                if (primo == 2)
                {
                    Console.Write(" " + v[i] + "[" + i + "]" + " ");
                }
                primo = 0;

            }

            Console.ReadKey();
        }
    }
}
