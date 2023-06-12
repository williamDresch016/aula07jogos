using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07jogos
{
    class Program
    {
        static void Main(string[] args)
        {


            Random sorteador = new Random();
            int numero;
            int sorteio = sorteador.Next(1,11);
            
            Console.WriteLine("Bem-vindo a conradito jogos \n");

            Console.WriteLine("Advinhe o numero entre 1 e 10");
            Console.WriteLine("Digite o numero:");
            numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > 10 )
            {
                Console.WriteLine("Digite um numero valido");
                Main(null);
                return;
            }

            if (numero == sorteio )
            {
                Console.WriteLine("Parabens,voce venceu o jogo");

            Console.ReadKey();
                return;
            }
            Console.WriteLine("Voce errou ! tente novamente");
                Main(null);
            Console.ReadKey();


        }
    }
}
