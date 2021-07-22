using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Raul";
            alunos[1] = "Larissa";
            alunos[2] = "Selma";
            alunos[3] = "Talita";
            alunos[4] = "Wesley";

            Console.WriteLine("Aluno 0: {0}", alunos[0]);
            Console.WriteLine("Aluno 1: {0}", alunos[1]);
            Console.WriteLine("Aluno 2: {0}", alunos[2]);
            Console.WriteLine("Aluno 3: {0}", alunos[3]);
            Console.WriteLine("Aluno 4: {0}", alunos[4]);

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 8.8, 9.2, 7.7, 9.5 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine(media);
        }
    }
}
