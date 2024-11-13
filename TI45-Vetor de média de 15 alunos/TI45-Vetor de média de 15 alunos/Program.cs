using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Vetor_de_média_de_15_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] nota = new int[15];
            double soma=0, media=0;
            Random rnd = new Random();
            Console.WriteLine("Vetor de 15 notas e de média");
            for(i=0;i<nota.Length;i++)
            {
                nota[i] = rnd.Next(1,10);
            }
            for (i = 0; i< nota.Length; i++)
            {
                soma = soma +nota[i];
            }
            media = soma / 15;
            Console.WriteLine("\nNota de 15 alunos");
            for (i = 0; i < nota.Length; i++)
            {
                if (i <= 12)
                {
                    Console.Write(nota[i] + ", ");
                }
                else if (i == 13)
                {
                    Console.Write(nota[i] + " e ");
                }
                else
                {
                    Console.Write(nota[i] + ".");
                }

            }
            Console.WriteLine("\n\nA média das notas é: "+Math.Round(media,2));
            Console.ReadKey();

            

        }
    }
}
