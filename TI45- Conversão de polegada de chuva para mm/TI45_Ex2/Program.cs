using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chuva_pol, chuva_mm;
            Console.WriteLine("Quantidade de Chuvas");
            Console.WriteLine("Digite uma quantidade de chuva, em polegadas: ");
            chuva_pol = double.Parse(Console.ReadLine());
            chuva_mm = 25.4 * chuva_pol;
            Console.WriteLine(chuva_pol + " pol de chuva, equivalem a " + Math.Round(chuva_mm, 1) + " mm de chuva!");
            Console.ReadKey();
        }
    }
}
