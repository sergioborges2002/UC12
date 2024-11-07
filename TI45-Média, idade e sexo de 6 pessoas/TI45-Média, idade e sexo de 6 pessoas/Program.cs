using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Média__idade_e_sexo_de_6_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, media = 0, idade = 0, sexo = 0, maidade = 0,meidade=0,pmenor,pmaior,pmulher; 
            Console.WriteLine("Idade e o sexo de 6 pessoas");
            for (i=1;i<=6;i++)
            {
                Console.WriteLine("Digite a idade da "+i+"ª pessoa");
                idade = double.Parse(Console.ReadLine());
                idade++;
                Console.WriteLine("Digite o sexo da "+i+"ª pessoa");
                Console.WriteLine("\nSelecione o Sexo - M = 0 -- F = 1");
                sexo=double.Parse(Console.ReadLine());
                if(sexo==1 && idade >= 18)
                {
                    sexo++;
                }
                if (idade >= 18)
                {
                    maidade++;
                }
                else
                {
                    meidade++;
                }
            }
            pmenor = 100 * meidade / 6;
            pmaior = 100 * maidade / 6;
            media = idade/ 6;
            pmulher = (sexo / 6) * 100;
            Console.Clear();
            Console.WriteLine("\nA média das idade das 6 pessoas é: "+Math.Round(media,1));
            Console.WriteLine("\nA porcentagem de maiores idades é "+Math.Round(pmaior,1)+"%");
            Console.WriteLine("\nA porcentagem de menores idades é " + Math.Round(pmenor, 1) + "%");
            Console.WriteLine("\nA porcentagem de mulheres, maiores de idade é " + Math.Round(pmulher, 1) + "%");
            Console.ReadKey();
        }
    }
}
