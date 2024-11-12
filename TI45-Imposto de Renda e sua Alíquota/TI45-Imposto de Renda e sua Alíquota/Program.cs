using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Imposto_de_Renda_e_sua_Alíquota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i,imp, aliq,renda_mes,cpf,dependentes,dependentes_im=0;
            Console.WriteLine("Imposto de renda");
            for (i = 1; i <= 10; i++)
            {

                Console.WriteLine("\nDigite a renda mensal da " + i + "ª pessoa");
                renda_mes = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite o CPF da " + i + "ª pessoa");
                cpf = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite o nº de dependentes da " + i + "ª pessoa");
                dependentes = double.Parse(Console.ReadLine());
                if (renda_mes <= 2824)
                {
                    aliq = 0;
                }
                else if (renda_mes <= 4236)

                {

                    aliq = renda_mes * 0.05;
                }
                else if (renda_mes <= 7060)
                {
                    aliq = renda_mes * 0.10;

                }
                else if (renda_mes <= 9884)
                {
                    aliq = renda_mes * 0.15;

                }
                else
                {
                    aliq = renda_mes * 0.20;
                }

                imp = aliq;
                dependentes_im = dependentes * 70.6;
                aliq = aliq - dependentes_im;

                Console.WriteLine("Renda Mensal: R$" + renda_mes);
                Console.WriteLine("Desconto de dependente: R$"+dependentes_im+" por "+dependentes+" dependentes");
                Console.WriteLine("Imposto de renda sem desconto: R$" + imp);
                Console.WriteLine("Imposto de renda com desconto de dependente: R$" + aliq);
            }

                Console.ReadKey();



        }
    }
}
