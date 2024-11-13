using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Vetor_Par_e_Ímpar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, contp = 0, conti=0;
            int[] v= new int[10];
            int[] par = new int[10];
            int[] impar = new int[10];
            Random rdn = new Random();
            Console.WriteLine("Vetor de 10 posições");
            Console.Write("\n");
            for (i = 0; i < v.Length; i++)
            {
                v[i] = rdn.Next(0,50);
                Console.Write(v[i] + " ");


            }
            for (i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    par[i] = v[i];
                    contp++;
                }
                else if (v[i] % 2 == 1)
                {
                    impar[i] = v[i];
                    conti++;
                }
            }
            Console.WriteLine("\n");
            if (contp <= 0)
            {
                Console.WriteLine("Não há números pares");
            }
            else if(conti <= 0)
            {
                Console.WriteLine("Não há números impares");
            }




            Console.ReadKey();
        }
    }
}
