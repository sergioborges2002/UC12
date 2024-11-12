using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Valor_de_S_de_nº_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i,n,s=0;
            Console.WriteLine("Valor de S dado de n");
            Console.WriteLine("\nS = 1+1¹/2²+1/3³+1/N");
            Console.WriteLine("\nDigite Valor de nº N para descobrir valor S");
            n=double.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                s = s+ 1 / Math.Pow(i, i);
            }
            Console.WriteLine ("\nO valor de S é: "+Math.Round(s,2)+" dado pelo nº "+n);
            Console.ReadKey();
            
        }
    }
}
