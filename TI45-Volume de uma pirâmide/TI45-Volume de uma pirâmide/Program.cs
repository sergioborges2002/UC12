using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area_base, altura, vol;
            Console.WriteLine("Volume de uma pirâmide");
            Console.WriteLine("Digite a área da base, em m²:");
            area_base = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da pirâmide, em m:");
            altura = double.Parse(Console.ReadLine());
            vol = (area_base * altura) / 3;
            Console.WriteLine("Volume da Pirâmide = " + Math.Round(vol, 2) + " m³");
            Console.ReadKey();
        }
    }
}