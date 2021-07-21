using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            // Utilizando método estático
            var resultado = CalculadoraEstatica.Somar(2, 2);
            Console.WriteLine(resultado);

            // Utilizando método não estático
            CalculadoraEstatica calc = new CalculadoraEstatica();
            var resultado2 = calc.Multiplicar(2, 2);
            Console.WriteLine(resultado2);

        }
    }
}
