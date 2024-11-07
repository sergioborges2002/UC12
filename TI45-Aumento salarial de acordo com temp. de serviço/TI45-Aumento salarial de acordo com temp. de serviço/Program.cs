using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Aumento_salarial_de_acordo_com_temp.de_serviço
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, temp_servi, sal_reaj,bonus;
            Console.WriteLine("Aumento salarial de acordo com tempo de serviço");
            Console.WriteLine("Digite salário atual:");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo de serviço na empresa em anos");
            temp_servi=double.Parse(Console.ReadLine());

            if (sal <= 500) {
                sal_reaj = sal * 1.25;
                Console.WriteLine("Foi reajustado em 25%");
               
            }
            else if (sal <= 1000)
            {
                sal_reaj = sal * 1.20;
                Console.WriteLine("Foi reajustado em 20%");
            }
            else if (sal <= 1500)
            {
                sal_reaj = sal * 1.15;
                Console.WriteLine("Foi reajustado em 15%");
            }
            else if (sal <= 2000)
            {
                sal_reaj = sal * 1.10;
                Console.WriteLine("Foi reajustado em 10%");

            }
            else
            {
                sal_reaj = sal;
                Console.WriteLine("Não houve reajuste no salário");
            }
            if(temp_servi < 1)
            {
                bonus = 0;
            }
            else if(temp_servi >=1 && temp_servi <= 3)
            {
                bonus = 100.00;
            }
            else if(temp_servi<=4 && temp_servi<=6)
            {
                bonus = 200.00;
            }
            else if (temp_servi <= 7 && temp_servi <= 10)
            {
                bonus = 300.00;
            }
            else
            {
                bonus = 500.00; 
            }
            Console.WriteLine("O salário reajuste é de R$ " + sal + " para R$ " + sal_reaj + " e com bônus de R$" + bonus);
            Console.ReadKey ();
            }
    }
}
