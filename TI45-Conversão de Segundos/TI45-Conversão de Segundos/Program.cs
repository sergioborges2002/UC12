using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Conversão_de_Segundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t, h, m, s;
            Console.WriteLine("Conversão de Segundos");
            Console.WriteLine("Digite um tempo, em segundos:");
            t = int.Parse(Console.ReadLine());
            h = t / 3600;
            m = (t % 3600) / 60;
            s = (t % 3600) % 60;
            Console.WriteLine(t + " seg. equivalem a: ");
            Console.WriteLine(h + " h, " + m + " min. e " + s + " seg.");
            Console.ReadKey();
        }
    }
}
