using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Série_de_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,n,anterior=0,proximo=1,atual=1;
            Console.WriteLine("Sequência de Fibonacci");
            Console.WriteLine("Digite algum número");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(atual);
                anterior = atual;
                atual = proximo;
                proximo = anterior + atual;
            }
            Console.WriteLine("\n\nO Fibonacci de " + n + " é " + anterior);
            Console.ReadKey ();
        }
    }
}
