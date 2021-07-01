using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qaul é o seu salário? ");
            double salario = int.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); // Essa linha pede para desconsiderar notação de ponto e virgula do sistema operacional.
                
            Console.WriteLine($"{nome}, {idade}, R${salario}");
        }
    }
}
