using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;

            Console.WriteLine("Digite sua nota: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
