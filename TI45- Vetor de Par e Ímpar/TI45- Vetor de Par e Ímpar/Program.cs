using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45__Vetor_de_Par_e_Ímpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,conti=0,contp=0;
            int[] par= new int[10];
            int[] impar = new int[10];
            Random rdn = new Random();
            Console.WriteLine("Vetor de 10 posições");
            Console.Write("\n");
            for (i=0;i<par.Length;i++)
            {
                par[i] = rdn.Next(0,50);
                Console.Write(par[i]+" ");


            }
            Console.WriteLine("\n\nVetores ímpares: ");
            for (i = 0; i < par.Length; i++) {
                if (par[i] % 2 == 1)
                {
                    
                    impar[i] = par[i];
                    Console.Write(impar[i] + " ");
                }
               

            }
            Console.WriteLine("\n\nVetores pares: ");
            for (i = 0; i < par.Length; i++)
            {
                if (par[i] % 2 == 0)
                {

                
                    Console.Write(par[i] + " ");
                }

            }
            
            Console.ReadKey();

        }
    }
}
