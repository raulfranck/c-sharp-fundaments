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

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();


            var fulano = new Pessoa();
            fulano.Nome = "Larissa Franck";
            fulano.Idade = 27;

            var segundaApresentacao = fulano.Apresentar();
            Console.WriteLine(segundaApresentacao);

            fulano.Zerar();
            Console.WriteLine(fulano);
        }


    }
}
