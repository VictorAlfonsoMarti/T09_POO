using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO
{
    class Coche
    {
        // ATRIBUTOS
        private string marca { set; get; }
        private string modelo { set; get; }
        private int cilindrada { set; get; }
        private float potencia { set; get; }



        // CONSTRUCTORES
        public Coche()
        {
        }

        public Coche(string marca, string modelo, int cilindrada, float potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
        }

        public static void CocheMain()
        {
            Coche coche1 = new Coche("Marca1", "Modelo1", 120, 2000);
            Coche coche2 = new Coche("Marca2", "Modelo2", 3, 50);

            Console.WriteLine("Marca: {0}, Modelo: {1}, Cilindrada: {2}, Potencia {3}.", coche1.marca, coche1.modelo, coche1.cilindrada, coche1.potencia);
            Console.WriteLine("Marca: {0}, Modelo: {1}, Cilindrada: {2}, Potencia {3}.", coche2.marca, coche2.modelo, coche2.cilindrada, coche2.potencia);
        }
    }
}
