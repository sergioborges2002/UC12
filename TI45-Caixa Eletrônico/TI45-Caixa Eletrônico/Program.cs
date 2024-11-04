using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Caixa_Eletrônico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n100, n50, n20, n10, n5, n2, saque;
            Console.WriteLine("Caixa Eletrônico - TI45");
            Console.WriteLine("Digite o valor do saque, em R$:");
            saque = int.Parse(Console.ReadLine());
            n100 = saque / 100;
            n50 = (saque % 100) / 50;
            n20 = ((saque % 100) % 50) / 20;
            n10 = (((saque % 100) % 50) % 20) / 10;
            n5 = ((((saque % 100) % 50) % 20) % 10) / 5;
            n2 = (((((saque % 100) % 50) % 20) % 10) % 5) / 2;
            Console.WriteLine("Um saque de R$ " + saque + " nos dá:");
            Console.WriteLine(n100 + " notas de R$100, " + n50 + " notas de R$50, " + n20 + " notas de R$20, " + n10 + " notas de R$10, " + n5 + " notas de R$5 e " + n2 + " notas de R$2");
            Console.ReadKey();
        }
    }
}
