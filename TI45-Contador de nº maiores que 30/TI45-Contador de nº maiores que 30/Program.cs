using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Contador_de_nº_maiores_que_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, cont30=0,num;
            Random rnd = new Random();
            Console.WriteLine("15 números - quantos são maiores que 30");
            Console.WriteLine("\n15 números aletórios entre 0 e 50:");
            for (i=1;i<=15;i++)
            {

                num = rnd.Next(0, 51);
                Console.Write(num+" ");
                if (num > 30)
                {
                    cont30++;
                }
                
            }
            Console.WriteLine("\n\nEntre os 15 números aleatórios gerados, "+cont30+" são maiores que 30");
            Console.ReadKey();
        }
    }
}
