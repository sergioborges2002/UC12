using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Série_de_Ricci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, ntermos, anterior = 0, proximo = 1, atual = 1;
            Console.WriteLine("Série de Ricci");
            Console.WriteLine("Digite o nº de termos");
            ntermos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 1º número");
            atual= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            proximo= int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Sequencia de ricci do " + atual + " e do " + proximo + " com " + ntermos + " termos ");
            for (i = 1; i <= ntermos; i++)
            {
                Console.WriteLine(atual);
                anterior = atual;
                atual = proximo;
                proximo = anterior + atual;
            }
            Console.ReadKey();
        }
    }
}
