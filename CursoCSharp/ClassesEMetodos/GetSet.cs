using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            setMarca(marca);
            setModelo(modelo);
            setCilindrada(cilindrada);
        }

        public Moto()
        {

        }

        public string getMarca()
        {
            return Marca;
        }

        public void setMarca(string marca)
        {
            Marca = marca;
        }

        public string getModelo()
        {
            return Modelo;
        }

        public void setModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int getCilindrada()
        {
            return Cilindrada;
        }

        public void setCilindrada(int cilindrada)
        {
            //if (cilindrada > 0)
            //{
            //Cilindrada = cilindrada;
            //}

            Cilindrada = Math.Abs(cilindrada); // Transforma em valor positivo.
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Harley", "883", -883);
            Console.WriteLine(moto1.getMarca());
            Console.WriteLine(moto1.getModelo());
            Console.WriteLine(moto1.getCilindrada());

            var moto2 = new Moto();
            moto2.setMarca("Harley");
            moto2.setModelo("FatBob");
            moto2.setCilindrada(-1200);
            Console.WriteLine(moto2.getMarca());
            Console.WriteLine(moto2.getModelo());
            Console.WriteLine(moto2.getCilindrada());

        }
    }
}
