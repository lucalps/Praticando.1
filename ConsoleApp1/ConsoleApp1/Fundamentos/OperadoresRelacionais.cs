using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10);
            Console.WriteLine("Passou {0}", nota > notaCorte);
            Console.WriteLine("Não passou {0}", nota < notaCorte);
        }
    }
}
