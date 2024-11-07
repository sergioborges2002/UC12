using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fat=1,num;
            Console.WriteLine("Fatorial");
            Console.WriteLine("Digite 1 número");
           num=int.Parse(Console.ReadLine());
            for (i = 1;i<=num; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine("\nO fatorial de "+num+" é "+fat);
            Console.ReadKey();
        }
    }
}
