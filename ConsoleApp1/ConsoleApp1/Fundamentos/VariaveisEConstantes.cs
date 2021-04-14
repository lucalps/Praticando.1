using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo:" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade:" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario:" + salario);

            int menorValor = int.MinValue; //Mais usados dos inteiros
            Console.WriteLine("Menor valor int:" + menorValor);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("população é:" + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("A população mundial é:" + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("o preço do pc é:" + precoComputador);

            double valorDoMercadoDaApple = 1_000_000_000_000.00; //Mais Usado
            Console.WriteLine("Valor do mercado da apple" + valorDoMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas" + distanciaEntreEstrelas);

            string texto = "Ola mundo!!";
            Console.WriteLine(texto);
        }
    }
}
