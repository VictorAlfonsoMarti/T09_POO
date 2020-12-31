using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO
{
    class Electrodomestico
    {
        // ATRIBUTOS
        private int precioBase { get; set; }
        private string color { get; set; }
        private string consumoEnergetico { get; set; }
        private int peso { get; set; }

        private const int precioBaseDefecto = 100;
        private const string colorDefecto = "blaco";
        private const string consumoEnergeticoDefecto = "F";
        private const int pesoDefecto = 5;

        private string[] colorDisponible = new string[] { "blanco", "negro", "rojo", "azul", "gris" };

        // CONSTRUCTORES
        public Electrodomestico()
        {
            this.precioBase = precioBaseDefecto;
            this.color = colorDefecto;
            this.consumoEnergetico = consumoEnergeticoDefecto;
            this.peso = pesoDefecto;
        }

        public Electrodomestico(int precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.color = colorDefecto;
            this.consumoEnergetico = consumoEnergeticoDefecto;
            this.peso = peso;
        }

        public Electrodomestico(int precioBase, string color, string consumoEnergetico, int peso)
        {
            this.precioBase = precioBase;
            this.color = CheckColor(color, colorDisponible); ;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }

        // METODOS

        public static string CheckColor(string color, string[] colorDisponible)
        {
            Boolean existe = false; 
            for (int x = 0; x < colorDisponible.Length; x++)
            {
                if (colorDisponible[x].Equals(color))
                {
                    existe = true;
                    break;
                }
            }

            if (existe == false)
            {
                Console.WriteLine("El color que has introducido no está disponible, por favor, selecciona uno de la siguiente lista: {0}.", string.Join(", ", colorDisponible));
                color = CheckColor(Console.ReadLine(), colorDisponible);
            }
            return color;
        }

        public static void TestElectrodomestico()
        {
            Electrodomestico test1 = new Electrodomestico(16, "blanco", "F", 56);
            Console.WriteLine("Precio: {0}, Color: {1}, Consumo: {2}, Peso {3}.", test1.precioBase, test1.color, test1.consumoEnergetico, test1.peso);


            Console.WriteLine("\n Pasamos el siguiente objeto electrodomestico con un color erronio: \n Electrodomestico test2 = new Electrodomestico(43, 'violeta', 'A', 3); \n");

            Electrodomestico test2 = new Electrodomestico(43, "violeta", "A", 3);
            Console.WriteLine("Precio: {0}, Color: {1}, Consumo: {2}, Peso {3}.", test2.precioBase, test2.color, test2.consumoEnergetico, test2.peso);
        }

    }
}
