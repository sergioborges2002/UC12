using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Empréstimo_de_funcionários_publicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, prestacao,percen;
            Console.WriteLine("Empréstimo para os funcionários públicos");
            Console.WriteLine("Digite o salário bruto");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da prestação");
            prestacao= double.Parse(Console.ReadLine());
            percen = (prestacao / salario)*100;
            Console.WriteLine("A porcentagem da prestação no salário bruto é: " + Math.Round(percen,2) + "%");
            if (prestacao <= salario * 0.30)
            {
                Console.WriteLine("O Empréstimo foi aprovado"); 
            }
            else
            {
                Console.WriteLine("O Empréstimo foi negado");
            }
            
            Console.ReadKey();
        }
    }
}
