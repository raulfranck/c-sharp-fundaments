using System;


namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);
            Console.WriteLine("tamanho".Length);

            string valorImportante = null;
        }
    }
}

