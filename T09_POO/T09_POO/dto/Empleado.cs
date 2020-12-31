using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO
{
    class Empleado
    {
        // ATRIBUTOS
        private string nombre { get; set; }
        private int sueldo { get; set; }

        // CONSTRUCTORES
        public Empleado()
        {
        }

        public Empleado(string nombre, int sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        // METODOS
        public void PrintarDatos()
        {
            Console.WriteLine("Nombre: {0} \nSueldo: {1}", nombre, sueldo);
        }

        public void PagaImpuestos()
        {
            if (sueldo > 3000) Console.WriteLine("{0} SI debe pagar impuestos.", nombre);
            else Console.WriteLine("{0} NO debe pagar impuestos.", nombre);
        }
    }
}
