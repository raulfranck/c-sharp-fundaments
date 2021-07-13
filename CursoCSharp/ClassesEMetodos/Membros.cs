using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Raul Franck";
            sicrano.Idade = 27;

            Console.WriteLine($"{sicrano.Nome}, {sicrano.Idade}");
        }
    }
}
