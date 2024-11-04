using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_45___dígitos_de_um_nº_de_4_digitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dig1, dig2, dig3, dig4;
            Console.WriteLine("Dígitos de um nº inteiro de 4 dígitos:");
            Console.WriteLine("Digite um nº com 4 dígitos (entre 1000 e 9999): ");
            num = int.Parse(Console.ReadLine());
            dig1 = num / 1000;
            dig2 = (num % 1000) / 100;
            dig3 = ((num % 1000) % 100) / 10;
            dig4 = ((num % 1000) % 100) % 10;
            Console.WriteLine("Dígitos do número " + num + ":");
            Console.WriteLine(dig1 + ", " + dig2 + ", " + dig3 + " e " + dig4);
            Console.ReadKey();
        }
    }
}