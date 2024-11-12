using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Valor_S_de_nº
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, n1,n2, s=0;
            Console.WriteLine("Leia um nº N positivo e calcule o valor de S");
            Console.WriteLine("Formula: S = 1/N + 2/N + 3/N");
            Console.WriteLine("Digite um nº");
            n1=double.Parse(Console.ReadLine());
            n2 = n1;
            
            for (i = 1; i <=n2; i++)
            {

                s = s + i / n1;
                n1--;
               
            }
            Console.WriteLine("O valor de S é: " + Math.Round(s, 2) + " dado pelo nº " + n2);
            Console.ReadKey();
        }
    }
}
