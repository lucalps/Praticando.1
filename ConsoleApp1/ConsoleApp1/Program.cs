using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Api;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"OperadoresAritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"OperadoresRelacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"OperadoresLogicos - Fundamentos", OperadoresLogicos.Executar},
                {"OperadoresAtribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"OperadoresUnarios - Fundamentos", OperadoresUnarios.Executar},
                {"OperadoreTernario - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"EstruturaIf - EstruturasDeControle", EstruturaIf.Executar},
                {"EstruturaIfElse - EstruturasDeControle", EstruturaIfElse.Executar},
                {"EstruturaIfElseIf - EstruturasDeControle", EstruturaIfElseIf.Executar},
                {"EstruturaSwitch - EstruturasDeControle", EstruturaSwitch.Executar},
                {"EstruturaWhile - EstruturasDeControle", EstruturaWhile.Executar},
                {"EstruturaDoWhile - EstruturasDeControle", EstruturaDoWhile.Executar},
                {"EstruturaFor - EstruturasDeControle", EstruturaFor.Executar},
                {"EstruturaForEach - EstruturasDeControle", EstruturaForEach.Executar},
                {"UsandoBreak - EstruturasDeControle", UsandoBreak.Executar},
                {"UsandoContinue - EstruturasDeControle", UsandoContinue.Executar},

                //Classes E Metodos
                {"Membros - ClassesEMetodos", Membros.Executar},
                {"Construtores - ClassesEMetodos", Construtores.Executar},
                {"MetodosComRetorno - ClassesEMetodos", MetodosComRetorno.Executar},
                {"MetodosEstaticos - ClassesEMetodos", MetodosEstaticos.Executar},
                {"AtributosEstaticos - ClassesEMetodos", AtributosEstaticos.Executar},

                //Api
                {"PrimeiroArquivo - Api", PrimeiroArquivo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}