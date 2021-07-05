﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie o atendimento com uma nota de 1 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);

            switch(nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regualar");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5: {
                        Console.WriteLine("Ótimo");
                        Console.WriteLine("Parabéns!!");
                        break;
                    }
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }
        }
    }
}
