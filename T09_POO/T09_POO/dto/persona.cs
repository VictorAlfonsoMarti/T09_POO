using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO.dto
{
    class Persona
    {
        // ATRIBUTOS
        private string nombre { get; set; }


        // CONSTRUCTORES
        public Persona()
        {
        }
        
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        // METODO
        public void SetNombre(string nuevoNombre) 
        {
            nombre = nuevoNombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", nombre);
        }
    }
}
