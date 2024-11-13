using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45__Vetor_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,sub;
            int[]A = new int[10];
            int[]B = new int[10];
            int[]C= new int[10];
            for(i=0;i<A.Length;i++)
            {
                Console.WriteLine("Digite o "+(i+1)+"º posicão do vetor A");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º posicão do vetor B");
                B[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("\nVetor A");
            for (i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]+" ");
            }

            Console.WriteLine("\nVetor B");
            for (i = 0; i < A.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.WriteLine("\nVetor C");
            for (i = 0; i < A.Length; i++)
            {
                Console.Write(C[i] + " ");
                C[i] = A[i] - B[i];
                
            }
            Console.ReadKey();

        }
    }
}
