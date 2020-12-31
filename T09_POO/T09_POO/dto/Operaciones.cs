using System;
using System.Collections.Generic;
using System.Text;

namespace T09_POO.dto
{
    class Operaciones
    {
        // ATRIBUTOS
        private int valorX { get; set; }
        private int valorY { get; set; }

        // CONSTRUCTORES
        public Operaciones()
        {
        }

        public Operaciones(int valorX, int valorY)
        {
            this.valorX = valorX;
            this.valorY = valorY;
        }

        // METODOS

        public void Suma()
        {
            Console.WriteLine("{0} + {1} = {2}", valorX, valorY, valorX + valorY);
        }

        public void Resta()
        {
            Console.WriteLine("{0} - {1} = {2}", valorX, valorY, valorX - valorY);
        }

        public void Multiplicacion()
        {
            Console.WriteLine("{0} * {1} = {2}", valorX, valorY, valorX * valorY);
        }

        public void Division()
        {
            Console.WriteLine("{0} / {1} = {2}", valorX, valorY, Convert.ToDecimal(valorX) / Convert.ToDecimal(valorY));
        }


    }
}
