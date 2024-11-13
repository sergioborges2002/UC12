using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Produto_escalar_de_A_por_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, p,soma=0;
            int[]a = new int[10];
            int[]b = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Produto escalar do vetor A pelo vetor B");
            Console.WriteLine("Vetor A");
            for (i=0;i<a.Length;i++)
            {
                a[i] = rnd.Next(1,20);
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\n\nVetor B");
            Console.WriteLine();
            for (i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(1, 20);
                Console.Write(b[i]+" ");
            }
            for (i = 0; i < a.Length; i++)
            {
                soma = soma + a[i] * b[i]; 
 
            }
            Console.WriteLine("\n\nO Produto escalar é: "+soma);
            Console.ReadKey ();
        }
    }
}
