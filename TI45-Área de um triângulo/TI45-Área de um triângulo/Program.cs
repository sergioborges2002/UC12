using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Area_de_um_Triângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, area;
            Console.WriteLine("Área de um Triângulo");
            Console.WriteLine("Digite o valor do 1º lado: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do 2º lado: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do 3º lado: ");
            c = double.Parse(Console.ReadLine());
            p = (a + b + c) / 2;
            //Math.Sqrt(x) = RaizQ(x)
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Área do triângulo: " + Math.Round(area, 1));
            Console.WriteLine("Digite qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
