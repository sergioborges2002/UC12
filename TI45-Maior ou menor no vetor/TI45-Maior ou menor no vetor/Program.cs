using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Maior_ou_menor_no_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, maior, menor,imenor=0,imaior=0;
            double media,soma=0;
            int[] n = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Vetor de 10 números");
            n[0]=rnd.Next(1,100);
            maior = n[0];
            menor = n[0];
            for (i=1;i<n.Length;i++) {
                n[i]= rnd.Next(1, 100);
            }
            for (i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");

            }
            
            for(i=0;i<n.Length;i++) {
                soma = soma + n[i];
                if (n[i]>maior)

                {
                    maior= n[i];
                   
                    imaior = i;

                }
                else if (n[i] < menor)
                {
                    menor = n[i];
                    imenor = i;
                    
                   
                }

            }
            media = soma / 10;
            Console.WriteLine("\n\nO Maior nº do vetor é: "+maior);
            Console.WriteLine("O índice do maior nº é: "+imaior);
            Console.WriteLine("\n\nO Menor nº do vetor é: " + menor);
            Console.WriteLine("O índice do menor nº é: " + imenor);
            Console.WriteLine("\n\nA média dos nº é: " + Math.Round(media,2));
            Console.ReadKey ();

        }
    }
}
