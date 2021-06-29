using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Raul";
            //nome = 123; // Não é possível atribuir um numero a uma string
            Console.WriteLine(nome);

            //var idade;
            //idade = 15;
            //Console.WriteLine(idade); // Variaveis do tipo implicito deve ser inicializada.

            int a; // Declarar a variável
            a = 5;
            int b = 15; // Declarar e inicializar.

            Console.WriteLine(a + b);
        }
    }
}
