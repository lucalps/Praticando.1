using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var trab1 = false;
            Boolean trab2 = false;

            var comprouTv50 = trab1 && trab2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            var comprouSorvete = trab1 || trab2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = trab1 ^ trab2;
            Console.WriteLine("Comprou TV? {0}", comprouTv32);

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
        }
    }
}
