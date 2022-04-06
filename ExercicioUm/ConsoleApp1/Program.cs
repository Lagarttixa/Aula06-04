using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dias que vc deseja pagar o produto: ");
            var entrada = Console.ReadLine();
            var dias = Convert.ToInt32(entrada);

            Console.WriteLine("Digite a valor do produto: ");
            var entrada2 = Console.ReadLine();
            var valor = Convert.ToDouble(entrada2);
            
            if(dias <= 30)
            {
               double resultado = valor * 1.08;
                Console.WriteLine("O valor do final é: " + resultado);
            }
            else if(dias <= 60)
            {
                double resultado = valor * 1.15;
                Console.WriteLine("O valor do final é: " + resultado);
            }
            else if(dias <= 90)
            {
                double resultado = valor * 1.21;
                Console.WriteLine("O valor do final é: " + resultado);
            }

            Console.ReadLine();
            
             
            
        }
    }
}
