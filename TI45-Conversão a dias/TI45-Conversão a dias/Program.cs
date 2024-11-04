using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Conversão_a_Dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, total;
            Console.WriteLine("Conversão a Dias");
            Console.WriteLine("Digite uma quantidade de anos:");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma quantidade de meses:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma quantidade de dias:");
            dia = int.Parse(Console.ReadLine());
            total = 365 * ano + 30 * mes + dia;
            Console.WriteLine(ano + " anos, " + mes + " meses e " + dia + " dias, equivalem, aproximadamente, a: " + total + " dias");
            Console.ReadKey();
        }
    }
}
