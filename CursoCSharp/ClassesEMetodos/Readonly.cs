using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento; // Com readonly, se torna um valor imutável, porém pode ser atribuido.

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataDeNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar()
        {
            var cliente1 = new Cliente("Raul Franck", new DateTime(1993, 10, 21));

            var data = cliente1.GetDataDeNascimento();

            Console.WriteLine(cliente1.Nome);
            Console.WriteLine(cliente1.GetDataDeNascimento());
        }
    }
}
