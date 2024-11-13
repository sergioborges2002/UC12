using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Vetor_de_50_posições
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] v = new int[50];
            Console.WriteLine("Vetor de 50 posições");
            for (i=0;i<v.Length;i++)
            {
                v[i] = (i + 5 * i) % (i + 1);
                Console.Write(v[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
