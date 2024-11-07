using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Soma_dos_números_e_dos_quadrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,soma1 = 0,soma2 = 0;
            Console.WriteLine("Números de 1 a 100 e sua soma e soma de seus quadrados");
            for (i=1;i<=100;i++)
            {
                if (i < 100)
                {
                    Console.Write(i + " + ");
                }
                else
                {
                    Console.WriteLine(i+".");
                }

                
                
                soma1 += i; //soma1 = soma1 +i;
                soma2 += i * i;//soma2 = soma 2 + i*i;

            }
            Console.WriteLine("\nSoma dos 100 primeiros números: "+soma1);
            Console.WriteLine("\nSoma dos quadrados dos 100 primeiros números: "+soma2);
            Console.ReadKey();
        }
    }
}
