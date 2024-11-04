using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Média_de_3_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.WriteLine("Média ponderada de Notas");
            Console.WriteLine("Digite a 1ª nota");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2ª nota");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3ª nota");
            n3 = double.Parse(Console.ReadLine());
            media = (n1 * 1 + n2 * 1 + n3 * 2) / 4;
            if (media >= 6.0)
            {
                Console.WriteLine("O Aluno foi aprovado com a média: "+Math.Round(media,1));
            }
            else
            {
                Console.WriteLine("O Aluno foi reprovado com a média: " + Math.Round(media,1));
            }
            Console.ReadKey();


        }
    }
}
