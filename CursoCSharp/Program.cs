using System;
using System.Collections.Generic;

using CursoCSharp.fundamentos;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferências - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatar Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Converções - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estrutura De Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estrutura De Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estrutura De Controle", EstruturaIfeIfElse.Executar},
                {"Estrutura Switch - Estrutura De Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura De Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura De Controle", EstruturaDoWhile.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}