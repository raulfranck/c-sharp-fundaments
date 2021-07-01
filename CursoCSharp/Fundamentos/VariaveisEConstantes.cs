using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // Raio da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area);
            Console.WriteLine("A área é: " + (area + 1000));

            // Tipos internos

            bool estaChovendo = true; 
            Console.WriteLine("Está chovendo ?:" + estaChovendo);

            byte idade = 45; // De 0 a 256
            Console.WriteLine("Idade é: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // -128 à 127
            Console.WriteLine("Saldo de gols é: " + saldoDeGols);

            short salario = short.MaxValue; // De -32768 à 32727
            Console.WriteLine("Salário é: " + salario);

            int menorValorInteiro = int.MinValue;
            Console.WriteLine("Menor valor dos números inteiros é: " + menorValorInteiro);

            uint populacaoBrasileira = 206_600_000;
            Console.WriteLine("A população brasileira é: " + populacaoBrasileira);

            long menorValorLong = long.MaxValue;
            Console.WriteLine("Menor valor do Long é: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial é: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("O preço do Computador é: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00; // Double é mais usado nos n
            Console.WriteLine("Valor de Mercado da Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("O valor da distância entre as estrelas é: " + distanciaEntreEstrelas);

            char letra = 'a'; // Apenas uma letra
            Console.WriteLine("Letra: " + letra);

            string palavra = "palavrinha"; // Palavra ou frases
            Console.WriteLine("A palavra é: " + palavra);

        }
    }
}
