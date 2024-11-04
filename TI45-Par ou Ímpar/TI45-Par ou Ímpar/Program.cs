using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_45___Par_ou_IMPAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Par ou ímpar?");
            Console.WriteLine("Digite um nº inteiro positivo:");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " é PAR!");
            }
            else
            {
                Console.WriteLine(num + " é ÍMPAR!");
            }
            Console.ReadKey();
        }
    }
}
