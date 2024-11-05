using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,res;
            int op;
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite 1º número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite entre 1 e 4");
            Console.WriteLine("1 - Média");
            Console.WriteLine("2 - Diferença");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Digite a opção desejada");   
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    res = (num1 + num2) / 2;
                    Console.WriteLine("A média entre " + num1 + " e " + num2 + " é " + res);
                    break;

                case 2:
                    res = num1 - num2;
                    Console.WriteLine("A diferença de " + num1 + " por " + num2 + " é " + res);
                    break;

                case 3:
                    res = num1 * num2;
                    Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " é " + res);
                    break;

                case 4:
                    res = num1 / num2;
                    Console.WriteLine("A divisão de " + num1 + " e " + num2 + " é " + res);

                    break;
                default:
                    Console.WriteLine("Não existe essa opção");
                    Console.WriteLine("Digite qualquer tecla para sair!");
                    Console.ReadKey ();
                    break;

            }
            Console.ReadKey();



        }
    }
}
