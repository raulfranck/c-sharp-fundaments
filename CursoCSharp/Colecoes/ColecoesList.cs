using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesList
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object obj)
            {
                Produto outroProduto = (Produto)obj;
                bool mesmoNome = Nome == outroProduto.Nome;
                bool mesmoPreco = Preco == outroProduto.Preco;
                return mesmoNome && mesmoPreco;
            }
        }
        public static void Executar()
        {
            var livro = new Produto("Por quem os sinos dobram", 49.99);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Adeus às armas", 29.90),
                new Produto("Guerra e paz", 30.00),
                new Produto("Crime e castigo", 29.99),
            };

            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(3);

            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.WriteLine("Livro 1 - {0}, Preço: {1}R$", item.Nome, item.Preco);
            }
        }
    }
}
