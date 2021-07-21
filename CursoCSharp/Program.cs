using System;
using System.Collections.Generic;

using CursoCSharp.fundamentos;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;


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
                {"Estrutura For - Estrutura De Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estrutura De Controle", EstruturaForEach.Executar},
                {"Usando o Break - Estrutura De Controle", Break.Executar},

                // Classes e Metodos
                {"Membros: Atributos e Metodos - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Parâmetro Variáveis - Classes e Metodos", Params.Executar},
                {"Parâmetro Nomeados - Classes e Metodos", ParametrosNoemados.Executar},
                {"Getters e Setters - Classes e Metodos", GetSet.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Struct - Classes e Metodos", Struct.Executar},

                // Coleções
                {"Struct - Coleções", Colecoes.Array.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}