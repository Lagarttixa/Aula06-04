using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o sua altura: ");
            var entrada = Console.ReadLine();
            var altura = Convert.ToDouble(entrada);

            Console.WriteLine("Digite seu sexo M=1 ou F=2: ");
            var entrada2 = Console.ReadLine();
            var sexo = Convert.ToInt16(entrada2);

            if (sexo == 1)
            {
                double resultado = (72.7 * altura) - 58;
                Console.WriteLine("O seu peso ideal é: " + resultado);
            }
            else if (sexo == 2)
            {
                double resultado = (62.1 * altura) - 44.7;
                Console.WriteLine("O seu peso ideal é: " + resultado);
            }

            Console.ReadLine();
        }   
    }
}
