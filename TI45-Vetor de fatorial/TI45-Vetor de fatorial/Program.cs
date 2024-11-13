using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Vetor_de_fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,ii,fat=1;
            int[] v = new int[5];
            int[] vfat = new int[5];
            Random rnd = new Random();
            Console.WriteLine("Vetor de 5 posições e seus fatoriais");
            for (i=0;i<v.Length;i++)
            {
                v[i] = rnd.Next(2,6);
                Console.Write(v[i]+" ");
            }
            Console.WriteLine("\n\nFatoriais");
            for (i=0;i<v.Length;i++)
            {
                for (ii = 1; ii <= v[i]; ii++)
                {
                    fat = fat * ii;
                    vfat[i] = fat;


                    
                }
                fat = 1;
                Console.Write(vfat[i] + " ");

            }
            

            Console.ReadKey();
        }
    }
}
