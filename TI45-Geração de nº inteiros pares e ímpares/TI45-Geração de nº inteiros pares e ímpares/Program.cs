using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Geração_de_nº_inteiros_pares_e_ímpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,num,par=0,impar=0;
            Random rng = new Random();
            Console.WriteLine("Geração de 200 números inteiros e se são pares ou ímpares");
            Console.WriteLine();
            for (i = 1; i <= 200; i++) {
                num=rng.Next(0,200);
                Console.Write(num + " ");
                if (num % 2 == 0) { 
             
                    par++;
                }
                else
                {
                    
                    impar++;
                }
            }
            Console.WriteLine("\n\nForam gerados "+par+" pares");
            Console.WriteLine("\n\nForam gerados " + impar + " ímpares");


            Console.ReadKey();
        }
    }
}
