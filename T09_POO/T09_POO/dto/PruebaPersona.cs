using System;
using System.Collections.Generic;
using System.Text;
using T09_POO.dto;

namespace T09_POO
{
    class PruebaPersona
    {
        // METODO
        public static void PruebaPersonaMain()
        {
            Persona enano = new Persona("Durin");
            Persona mago = new Persona("Gandalf el Gris");

            enano.Saludar();
            enano.SetNombre("Durin II");
            enano.Saludar();

            mago.Saludar();
            mago.SetNombre("Gandalf el Blanco");
            mago.Saludar();
        }
    }
}
