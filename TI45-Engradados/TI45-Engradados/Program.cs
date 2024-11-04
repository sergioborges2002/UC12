using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Engradados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int garrafas, engra, sobra;
            Console.WriteLine("Engradados de Cerveja");
            Console.WriteLine("Digite a quantidade de garrafas que deseja embalar: ");
            garrafas = int.Parse(Console.ReadLine());
            engra = garrafas / 24;
            sobra = garrafas % 24;
            Console.WriteLine("Serão necessários " + engra + " engradados e sobrarão " + sobra + " garrafas sem embalar!");
            Console.ReadKey();
        }
    }
}
