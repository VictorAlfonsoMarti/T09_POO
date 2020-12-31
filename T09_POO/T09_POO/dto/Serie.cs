using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO
{
    class Serie
    {
        // ATRIBUTOS
        private string titulo {get; set;}
        private int numeroTemporadas { get; set; }
        private Boolean entregado { get; set; }
        private string genero { get; set; }
        private string creador { get; set; }

        private const int numeroTemporadasDefecto = 3;
        private const Boolean entregadoDefecto = false;


        // CONSTRUCTORES
        public Serie()
        {
            this.titulo = "vacio";
            this.numeroTemporadas = numeroTemporadasDefecto;
            this.entregado = entregadoDefecto;
            this.genero = "vacio";
            this.creador = "vacio";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadasDefecto;
            this.entregado = entregadoDefecto;
            this.genero = "vacio";
            this.creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, bool entregado, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            this.entregado = entregado;
            this.genero = genero;
            this.creador = creador;
        }

        // METODOS
        public static void TestSerie()
        {
            Serie serie1 = new Serie();
            Serie serie2 = new Serie("Titulo Serie 2", "Creador Serie 2");
            Serie serie3 = new Serie("Titulo Serie 3", 5, true, "Comedia", "Creador Serie 3");


            Console.WriteLine("Titulo: {0} || Numero de Temporadas: {1} || Entregado: {2} || Genero: {3} || Creador: {4}", serie1.titulo, serie1.numeroTemporadas, serie1.entregado, serie1.genero, serie1.creador);
            Console.WriteLine("Titulo: {0} || Numero de Temporadas: {1} || Entregado: {2} || Genero: {3} || Creador: {4}", serie2.titulo, serie2.numeroTemporadas, serie2.entregado, serie2.genero, serie2.creador);
            Console.WriteLine("Titulo: {0} || Numero de Temporadas: {1} || Entregado: {2} || Genero: {3} || Creador: {4}", serie3.titulo, serie3.numeroTemporadas, serie3.entregado, serie3.genero, serie3.creador);
        }
  


    }
}
