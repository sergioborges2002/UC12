using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Aposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, temp;
            Console.WriteLine("Condições para aposentar");
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu tempo de trabalho em anos");
            temp= int.Parse(Console.ReadLine());

            if (idade>=65){
                Console.WriteLine("Pode se aposentar");

            }
            else if (temp >= 30)
            {
                Console.WriteLine("Pode se aposentar");
            }
            else if (idade>=60 && temp >= 25)
            {
                Console.WriteLine("Pode se aposentar");
            }
            else
            {
                Console.WriteLine("Não pode se aposentar");
            }
            Console.WriteLine("Digite qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
