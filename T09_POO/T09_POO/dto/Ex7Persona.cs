using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO
{
    class Ex7Persona
    {
        // ATRIBUTOS
        private string nombre { get; set; }
        private int edad { get; set; }
        private string dni { get; set; }
        private double peso { get; set; }
        private int altura { get; set; }
        private string sexo { get; set; }

        private const string GENERO = "M";

        // CONSTRUCTOR
        public Ex7Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.dni = "123456789X";
            this.peso = 0;
            this.altura = 0;
            this.sexo = GENERO;
        }

        public Ex7Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Ex7Persona(string nombre, int edad, string dni, double peso, int altura, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.peso = peso;
            this.altura = altura;
            this.sexo = sexo;
        }

        // METODO

        public static void TestPersona()
        {
            Ex7Persona test1 = new Ex7Persona();
            Ex7Persona test2 = new Ex7Persona("Juanito", 14, "F");
            Ex7Persona test3 = new Ex7Persona("Pepito", 14,"987654321A", 80.5, 182, "M");
            

            Console.WriteLine("Nombre: {0}, Edad: {1}, DNI: {2}, Peso: {3}, Altura: {4}, Sexo: {5}.", test1.nombre, test1.edad, test1.dni, test1.peso, test1.altura, test1.sexo);
            Console.WriteLine("Nombre: {0}, Edad: {1}, DNI: {2}, Peso: {3}, Altura: {4}, Sexo: {5}.", test2.nombre, test2.edad, test2.dni, test2.peso, test2.altura, test2.sexo);
            Console.WriteLine("Nombre: {0}, Edad: {1}, DNI: {2}, Peso: {3}, Altura: {4}, Sexo: {5}.", test3.nombre, test3.edad, test3.dni, test3.peso, test3.altura, test3.sexo);
        }

    }
}
