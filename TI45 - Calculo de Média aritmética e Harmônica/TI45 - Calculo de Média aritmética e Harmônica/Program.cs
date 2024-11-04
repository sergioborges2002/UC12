using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, ma, mh;
            Console.WriteLine("Média Aritmética e harmônica de 5 valores");
            Console.WriteLine("Digite o 1º valor:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º valor:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4º valor:");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 5º valor:");
            e = double.Parse(Console.ReadLine());
            ma = (a + b + c + d + e) / 5;
            mh = 5 / (1 / a + 1 / b + 1 / c + 1 / d + 1 / e);
            Console.WriteLine("Média Aritmética: " + Math.Round(ma, 4));
            Console.WriteLine("Média Harmônica: " + Math.Round(ma, 4));
            Console.ReadKey();
        }
    }
}
