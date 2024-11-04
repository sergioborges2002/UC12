using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_45___Aumento_de_Salário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, aumento, sal_novo;
            Console.WriteLine("Aumento de Salário");
            Console.WriteLine("Digite o salário, em R$: ");
            sal = double.Parse(Console.ReadLine());
            if (sal < 2500) { aumento = 0.30 * sal; }
            else { aumento = 0.20 * sal; }
            sal_novo = sal + aumento;
            Console.WriteLine("Salário Antigo: R$ " + sal);
            Console.WriteLine("Aumento: R$ " + Math.Round(aumento, 2));
            Console.WriteLine("Salário Reajustado: R$ " + Math.Round(sal_novo, 2));
            Console.ReadKey();
        }
    }
}
