using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO.dto
{
    class Alumno
    {
        // ATRIBUTOS
        private string nombre { get; set; }
        private int edad { get; set; }


        //CONSTRUCTORES
        public Alumno()
        {
        }

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // METODOS
        public void PrintarDatos()
        {
            Console.WriteLine("Nombre: {0}  \nEdad: {1}", nombre, edad);
        }

        public void PrintarSiMayorEdad()
        {
            if (edad >= 18) Console.WriteLine("{0} es MAYOR de edad.", nombre);
            else Console.WriteLine("{0} es MENOR de edad.", nombre);
        }


    }
}
