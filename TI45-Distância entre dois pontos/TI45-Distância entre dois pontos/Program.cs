using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Distância_entre_2_pontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA, yA, xB, yB, dist;
            Console.WriteLine("Distância entre dois pontos A e B");
            Console.WriteLine("Digite o valor da abcissa de A (xA):");
            xA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da ordenada de A (yA):");
            yA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da abcissa de B (xB):");
            xB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da ordenada de B (yB):");
            yB = double.Parse(Console.ReadLine());
            dist = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            Console.WriteLine("Distância entre A e B: " + Math.Pow(dist, 1));
            Console.ReadKey();
        }
    }
}
