using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento: dd/mm/aaaa");
            var entrada = Console.ReadLine();
            var nascimento =Convert.ToDateTime(entrada);
            int idade = DateTime.Now.Year - nascimento.Year;
            Console.WriteLine("Você tem " + idade + " anos");

            if (idade >= 16)
            {
                Console.WriteLine("Você já pode votar");
            }
            if (idade >= 18)
            {
                Console.WriteLine("Você já pode tirar a CNH");
            }
            Console.ReadLine();
        }
    }

        

}
