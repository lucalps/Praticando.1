using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios
{
    class ParEImpar
    {
        public static void par()
        {
            var num1 = 55;

            //Console.WriteLine("Digite um numero: ");
            //var entrada = Console.ReadLine();


            if (num1 % 2 == 0)
            {
                Console.WriteLine("O numero {0} é par", num1);
            }
            else
            {
                Console.WriteLine("o numero{0} é impar", num1);
            }
        }
    }
}
