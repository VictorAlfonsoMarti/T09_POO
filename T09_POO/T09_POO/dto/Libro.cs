using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO
{
    class Libro
    {
        // ATRIBUTOS
        private string autor { get; set; }
        private string titulo { get; set; }
        private string ubicacion { get; set; }


        // CONSTRUCTORES
        public Libro()
        {
        }

        public Libro(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }

        // METODES
        public static void LibroMain()
        {
            Libro llibre1 = new Libro("J.R.R. Tolking", "El Señor de los Anillos", "La Tierra Media");
            Libro llibre2 = new Libro("H.P. Lovecraft", "La Llamada de Cthulhu", "Espacio Exterior");

            Console.WriteLine("Llibre: {0} || Autor: {1} || Ubicació {2}.", llibre1.titulo, llibre1.autor, llibre1.ubicacion);
            Console.WriteLine("Llibre: {0} || Autor: {1} || Ubicació {2}.", llibre2.titulo, llibre2.autor, llibre2.ubicacion);
        }

    }
}
