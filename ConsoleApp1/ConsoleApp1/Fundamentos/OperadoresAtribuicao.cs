using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7; //eu to trocando o 3 pelo 7
            num1 += 10; //num1 = num1 + 10 que da 17
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;
            Console.WriteLine("{0}", num1);

            int a = 1;
            int b = a;

            a++; //a = a + 1
            b--; //b = b -1
            Console.WriteLine($"{a} {b}");
        }
    }
}
