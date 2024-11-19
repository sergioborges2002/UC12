using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Interseção_de_vetores_anteriores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[10];
            Random rnd = new Random();
            int i, ii, cont = 0;

            Console.WriteLine("\n------------- vetor 1 -------------");
            for (i = 0; i < v1.Length; i++)
            {
                v1[i] = rnd.Next(1, 20);
                Console.Write(v1[i] + " ");
            }




            Console.WriteLine("\n------------- vetor 2 -------------");
            for (i = 0; i < v1.Length; i++)
            {
                v2[i] = rnd.Next(1, 20);
                Console.Write(v2[i] + " ");
            }
            Console.WriteLine("\n--------- numeros iguais  -------------");

            for (i = 0; i < v1.Length; i++)
            {
                for (ii = 0; ii < v1.Length; ii++)
                {
                    if (v1[i] == v2[ii])
                    {
                        v3[cont] = v1[i];
                        cont++;

                    }
                }
            }
            for (i = 1; i <= cont; i++)
            {
                for (ii = i - 1; ii >= 0; ii--)
                {
                    if (v3[ii] == v3[i])
                    {
                        v3[i] = 0;
                    }
                }
            }
            for (i = 0; i < cont; i++)
            {
                if (v3[i] == 0)
                {
                    Console.Write("");
                }
                else { Console.Write(v3[i] + " "); }

            }
            Console.ReadKey();
        }
    }
}
