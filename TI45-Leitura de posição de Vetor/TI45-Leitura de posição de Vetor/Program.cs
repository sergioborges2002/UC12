using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Leitura_de_posição_de_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, soma = 0, x, y;
            int[] v = new int[8];
            Random rnd = new Random();
            Console.WriteLine("Vetor de 8 elementos aleatórios inteiros entre 1 e 20");
            for (i = 0; i < v.Length; i++) { v[i] = rnd.Next(1, 21); }
            for (i = 0; i < v.Length; i++) { Console.Write(v[i] + "  "); }
            Console.WriteLine("\n\nDigite uma posição x(0 a 7): ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma posição y(0 a 7): ");
            y = int.Parse(Console.ReadLine());
            soma = v[x] + v[y];
            Console.WriteLine("v[" + x + "] + v[" + y + "] = " + v[x] + " + " + v[y] + " = " + soma);
            Console.ReadKey();

        }
    }
}
