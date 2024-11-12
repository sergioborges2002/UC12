using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Maior_ou_menor_aleatório
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, maior, menor, x;
            Console.WriteLine("digite 50 numeros : ");

            x = int.Parse(Console.ReadLine());

            maior = x;
            menor = x;

            Random rnd = new Random();


            for (i = 1; i <= 50; i++)
            {
                x = rnd.Next(0, 100);
                Console.Write(x + " ");
                if (x > maior) { maior = x; }
                else if (x < menor)
                {
                    menor = x;
                }
            }
            Console.WriteLine("o maior numero é " + maior);
            Console.WriteLine("o menor numero é " + menor);
            Console.ReadKey();
        }
    }
}
