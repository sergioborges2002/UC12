using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Eliminação_de_vetores_com_valor_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, cont = 0;
            int[] vet = new int[15];
            int[] vet2 = new int[15];
            Random rnd = new Random();


            Console.WriteLine(" vetor de 15 elementos ");

            for (i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(0, 10);
                Console.Write(vet[i] + " ");

            }

            Console.WriteLine("\n---- vetor sem os 0 ---");

            for (i = 0; i < vet.Length; i++)
            {
                if (vet[i] > 0)
                {
                    vet2[cont] = vet[i];
                    cont++;
                }

            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(vet2[i] + " ");
            }


            Console.ReadKey();
        }
    }
}
