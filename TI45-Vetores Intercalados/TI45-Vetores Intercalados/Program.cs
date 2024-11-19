using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Vetores_Intercalados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,cont=0,cont2=1;
            int[] vetA = new int[6];
            int[] vetB = new int[6];
            int[] inter = new int[12];
            Random rdn = new Random();
            Console.WriteLine("Vetores intercalados");
            Console.WriteLine("\nVetor A");
            for(i=0;i<vetA.Length;i++)
            {
                vetA[i] = rdn.Next(0,50);
                Console.Write(vetA[i]+" ");
            }
            Console.WriteLine("\n\nVetor B");
            for (i = 0; i < vetB.Length; i++)
            {
                vetB[i] = rdn.Next(0,50);
                Console.Write(vetB[i]+" ");
            }
            Console.WriteLine("\n");
            for (i = 0; i <vetA.Length; i++)
            {
                inter[cont] = vetA[i];
                inter[cont2*2-1] = vetB[i];
                cont2++;
                cont = +2;
                
               
            }
            for (i = 0; i < inter.Length; i++)
            {
                Console.Write(inter[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
