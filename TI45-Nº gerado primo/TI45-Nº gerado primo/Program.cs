using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Nº_gerado_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num1, num2, soma = 0, aux;
            Console.WriteLine("Intervalo entre dois números");
            Console.WriteLine("Digite 1º número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)//Troca de Variáveis
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }
            Console.WriteLine("Números no intervalo entre " + num1 + " e " + num2 + ":");
            for (i = num1; i <= num2; i++)
            {
                Console.Write(i + " ");
                soma += i;
            }
            Console.WriteLine("\n\nNúmeros Pares entre " + num1 + " e " + num2 + ":");
            for (i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n\nNúmeros Ímpares entre " + num1 + " e " + num2 + ":");
            for (i = num1; i <= num2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n\nSoma entre " + num1 + " e " + num2 + ":" + soma);
            Console.ReadKey();
        }
    }
}
