using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, cont = 0;
            Console.WriteLine("Números Primos");
            Console.WriteLine("Digite um nº inteiro positivo:");
            num=int.Parse(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            if(cont == 2)
            {
                Console.WriteLine(num+" É primo!");
            }
            else
            {
                Console.WriteLine(num+" Não é primo!");
            }
            Console.ReadKey();
        }
    }
}
