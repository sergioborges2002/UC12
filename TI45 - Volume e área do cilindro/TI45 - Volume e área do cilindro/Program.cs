using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, area, vol;
            Console.WriteLine("Área e Volume de um cilindro");
            Console.WriteLine("Digite o valor do raio do cilindro, em cm:");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do cilindro, em cm:");
            //Math.PI é o valor do PI = 3.14........
            altura = double.Parse(Console.ReadLine());
            area = 2 * Math.PI * raio * (altura + raio);
            //Math.Pow(raio,2) = raio ^2 = raio²
            vol = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("Área do Cilindro = " + Math.Round(area, 1) + " cm²");
            Console.WriteLine("Volume do Cilindro = " + Math.Round(vol, 1) + " cm³");
            Console.ReadKey();
        }
    }
}
