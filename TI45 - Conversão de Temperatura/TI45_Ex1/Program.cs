using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo de dados real = float, double
            //EM C#:  <tipo de dado> <nome variável>;
            double tc, tf;
            Console.WriteLine("Conversão de temperaturas F a C:");
            Console.WriteLine("Digite uma temperatura em °F: ");
            //A leitura em C# deve ser convertida, pois o Console
            //(modo shell) é uma caixa de texto
            //tf = Convert.ToDouble(Console.ReadLine());
            tf = double.Parse(Console.ReadLine());
            tc = 5 * (tf - 32) / 9;
            Console.WriteLine(tf + "°F = " + Math.Round(tc, 1) + "°C");
            Console.WriteLine("Digite qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
