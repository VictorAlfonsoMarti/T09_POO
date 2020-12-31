using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T09_POO
{
    class Password
    {
        // ATRIBUTOS
        private int longitud { get; set; }
        private string contraseña { get; set; }

        private static Random Aleatorio = new Random();
        const string contraseñaRandom = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


        // CONSTRUCTORES
        public Password()
        {
            this.longitud = 8;
            this.contraseña = contraseña;
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = new string(Enumerable.Repeat(contraseñaRandom, longitud).Select(s => s[Aleatorio.Next(s.Length)]).ToArray()); // genera una contraseña cogiendo valores aleatorios del string contraseñaRandom
        }

        // METODO
        public static void TestPassword()
        {
            Password pass1 = new Password();
            Password pass2 = new Password(14);

            Console.WriteLine("Pass1 (tamaño={0}): {1}", pass1.longitud, pass1.contraseña);
            Console.WriteLine("Pass1 (tamaño={0}): {1}", pass2.longitud, pass2.contraseña);
        }
    }
}
