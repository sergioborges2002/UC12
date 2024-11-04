using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace TI45___Conversão_de_Dias_a_Anos__Meses_e_Semanas

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int t, a, m, s, d;

            Console.WriteLine("Conversão de Dias a Anos, meses, Semanas e Dias");

            Console.WriteLine("Digite uma quantidade de dias:");

            t = int.Parse(Console.ReadLine());

            a = t / 365;

            m = (t % 365) / 30;

            s = ((t % 365) % 30) / 7;

            d = ((t % 365) % 30) % 7;

            Console.WriteLine(t + " dias equivalem, aproximadamente, a: ");

            Console.WriteLine(a + " anos, " + m + " meses, " + s + " semanas e " + d + " dias...");

            Console.ReadKey();

        }

    }

}


