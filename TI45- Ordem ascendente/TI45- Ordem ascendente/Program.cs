using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45__Ordem_ascendente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Valores em forma ascendente");
            Console.WriteLine("Digite o valor A");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor C");
            c = int.Parse(Console.ReadLine());
            if (a<b && b<c)
            {
                Console.WriteLine("Valor A: "+a+ ", Valor B: "+b+ ", Valor C: "+c);
                
            }
            if (a<c && c<b )
            {
                Console.WriteLine("Valor A: " + a + ", Valor C: " + c + ", Valor B: " + b);
            }
            if(b<a && a < c)
            {
                Console.WriteLine("Valor B: " + b + ", Valor A: " + a + ", Valor C: " + c);
             
            }
            if (b<c && c < a)
            {
                Console.WriteLine("Valor B: " + b + ", Valor C: " + c + ", Valor A: " + a);
            }
            if(c<b && b < a)
            {
                Console.WriteLine("Valor C: " + c + ", Valor B: " + b + ", Valor A: " + a);
            }
            if(c<a && a < b){
                Console.WriteLine("Valor C: " + c + ", Valor A: " + a + ", Valor B: " + b);
            }
            if (a<=b && b <= c) {
                Console.WriteLine("Valor A: " + a + ", Valor B: " + b + ", Valor C: " + c);
            }
            
                
            
            Console.ReadKey();
        }
    }
}
