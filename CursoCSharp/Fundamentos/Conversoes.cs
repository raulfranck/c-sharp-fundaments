using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade:");
            string idadeString = Console.ReadLine();
            Console.WriteLine(idadeString.GetType());
            int idadeInteira = int.Parse(idadeString);
            Console.WriteLine("Idade inserida convertida: {0}", idadeInteira);

            idadeInteira = Convert.ToInt32(idadeString); // Outra forma de converter.
            Console.WriteLine(idadeInteira);
        }
    }
}
