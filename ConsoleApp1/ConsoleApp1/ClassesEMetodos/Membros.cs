using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Lucas";
            sicrano.Idade = 18;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade}");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;
        }
    }
}
