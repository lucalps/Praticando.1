﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco;
        }
            

    }

    class AtributosEstaticos
    {
        public static void Executar()
        {

        }
    }
}
