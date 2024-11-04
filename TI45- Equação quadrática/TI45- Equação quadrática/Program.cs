using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45__ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Discriminante de uma equação de 2º grau - ax² + bx + c = 0");
            Console.WriteLine("Digite o valor de a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c:");
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Discriminante (delta) da equação, vale: " + delta);
            Console.ReadKey();
        }
    }
}
