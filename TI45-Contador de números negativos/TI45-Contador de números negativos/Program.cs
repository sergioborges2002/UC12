using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Contador_de_números_negativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, contn=0, soma=0,num;
            Random rng = new Random();
            Console.WriteLine("Quantidade de números negativos gerados e a soma dos positivos gerados");
            for (i = 1; i <= 25; i++)
            {
                num= rng.Next(-100,100);
                Console.Write(num + " ");

                if (num < 0)
                {
                    contn++;

                }
                else
                {
                    soma=+num;
                }
            }
            Console.WriteLine("\n\nForam gerados "+contn+" números negativos");
            Console.WriteLine("\nE a soma dos números positivos é: " + soma);
            Console.ReadKey();

        }
    }
}
