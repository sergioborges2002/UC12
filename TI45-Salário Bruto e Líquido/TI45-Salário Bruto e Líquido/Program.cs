using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45___Salário_Bruto_e_Líquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double horas, horas_extras, sal_liq, sal_bruto, imp;
            string nome;
            Console.WriteLine("Salário de um Funcionário");
            Console.WriteLine("Digite o nome da pessoa:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite quantas horas trabalhadas:");
            horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas horas extras trabalhadas:");
            horas_extras = double.Parse(Console.ReadLine());
            sal_bruto = 30 * horas + 35 * horas_extras;
            imp = 0.10 * sal_bruto;
            sal_liq = sal_bruto - imp;
            Console.WriteLine("Relatório de " + nome + ":");
            Console.WriteLine("Salário Bruto: R$ " + sal_bruto);
            Console.WriteLine("Desconto Impostos: R$ " + imp);
            Console.WriteLine("Salário Líquido: R$ " + sal_liq);
            Console.ReadKey();
        }
    }
}
