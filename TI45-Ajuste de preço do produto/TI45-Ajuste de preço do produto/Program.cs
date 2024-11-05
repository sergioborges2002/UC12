using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Ajuste_de_preço_do_produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco_antigo,preco_novo;
            Console.WriteLine("Ajuste de preços dos produtos");
            Console.WriteLine("Digite o preço do produto");   
            preco_antigo = double.Parse(Console.ReadLine());

            if(preco_antigo <= 50)
            {
                preco_novo = preco_antigo * 1.05;
                Console.WriteLine("O preço foi reajustado por 5%");

            }
            else if(preco_antigo >=50 && preco_antigo<=100 ){
                preco_novo = preco_antigo * 1.10;
                Console.WriteLine("O preço foi reajustado por 10%");
            }
            else
            {
                preco_novo = preco_antigo * 1.15;
                Console.WriteLine("O preço foi reajustado por 15%");
            }
            Console.WriteLine("--------------------------");
            if(preco_novo <= 80)
            {
                Console.WriteLine("O preço novo é R$ "+Math.Round(preco_novo,2)+" - BARATO");
            }
            else if(preco_novo >=80 && preco_novo <= 120)
            {
                Console.WriteLine("O preço novo é R$ " + Math.Round(preco_novo, 2) + " - NORMAL");
            }
            else if(preco_novo>=120 && preco_novo <= 200)
            {
                Console.WriteLine("O preço novo é R$ " + Math.Round(preco_novo, 2) + " - CARO");
            }
            else
            {
                Console.WriteLine("O preço novo é R$ " + Math.Round(preco_novo, 2) + " - MUITO CARO");
            }
            Console.ReadKey();
        }
    }
}
