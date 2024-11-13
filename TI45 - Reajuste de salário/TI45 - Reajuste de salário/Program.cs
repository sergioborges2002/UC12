using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Reajuste_de_salário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] sal = new int[8];
            Random rnd = new Random();
            Console.WriteLine("Vetor de 6 Salários com reajuste de 15%");
            for(i=0;i<sal.Length; i++)
            {
                sal[i] = rnd.Next(1412,10000);
            }
            for (i = 0; i < sal.Length; i++)
            {
                if (i <= 5)
                {
                    Console.Write("R$ " + sal[i] + ", ");
                }
                else if (i == 6)
                {
                    Console.Write("R$ " + sal[i] + " e ");
                }
                else
                {
                    Console.Write("R$ " + sal[i] + ".");
                }

            }
           
            Console.WriteLine("\n\nReajuste de 15% salário");
            for (i = 0; i < sal.Length; i++)
            {
                if (i <= 5)
                {
                    Console.Write("R$ "+Math.Round((sal[i]*1.15),2) + ", ");
                }
                else if (i == 6)
                {
                    Console.Write("R$ " + Math.Round((sal[i] * 1.15), 2) + " e ");
                }
                else
                {
                    Console.Write("R$ " + Math.Round((sal[i] * 1.15), 2) + ".");
                }
            }
            Console.ReadKey();
        }
    }
}
