using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "Renegage";
            carro1.Fabricante = "Geep";
            carro1.Ano = 2021;
            Console.WriteLine($"{carro1.Fabricante}, {carro1.Modelo}, {carro1.Ano}");

            // Passando parâmetro.
            var carro2 = new Carro("Onix", "Chevrolet", 2020);
            Console.WriteLine($"{carro2.Fabricante}, {carro2.Modelo}, {carro2.Ano}");

            // Outra forma passando Parâmetro.
            var carro3 = new Carro()
            {
                Modelo = "Uno",
                Fabricante = "Fiat",
                Ano = 2019,
            };
            Console.WriteLine($"{carro3.Fabricante}, {carro3.Modelo}, {carro3.Ano}");
        }
    }
}
