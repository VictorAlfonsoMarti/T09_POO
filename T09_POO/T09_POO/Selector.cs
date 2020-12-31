using System;
using System.Collections.Generic;
using System.Text;
using T09_POO.dto;

namespace T09_POO
{
    class Selector
    {
        // selector de ejercicios. ejecuta métodos según el ejercicio que se quiera comprobar.
        public static void SelectorEjercicio()
        {
            Console.WriteLine("Indica el ejercicio que quieres ejecutar: (Número del 1 al 10)");
            string ejercicio = Console.ReadLine();

            switch (ejercicio) //ejecutamos el método según el ejercicio.
            {
                case "1":
                    Alumno pepito = new Alumno("pepito grillo", 3);
                    Alumno manolo = new Alumno("manolito", 25);

                    pepito.PrintarDatos();
                    pepito.PrintarSiMayorEdad();

                    manolo.PrintarDatos();
                    manolo.PrintarSiMayorEdad();
                    break;
                case "2":
                    Empleado pobre1 = new Empleado("pobre1", 3);
                    Empleado rico1 = new Empleado("rico1", 9999);

                    pobre1.PrintarDatos();
                    pobre1.PagaImpuestos();

                    rico1.PrintarDatos();
                    rico1.PagaImpuestos();
                    break;
                case "3":
                    Operaciones op1 = new Operaciones(2, 5);
                    Operaciones op2 = new Operaciones(26, 87);

                    op1.Suma();
                    op1.Resta();
                    op1.Multiplicacion();
                    op1.Division();

                    op2.Suma();
                    op2.Resta();
                    op2.Multiplicacion();
                    op2.Division();

                    break;
                case "4":
                    PruebaPersona.PruebaPersonaMain();
                    break;
                case "5":
                    Libro.LibroMain();
                    break;
                case "6":
                    Coche.CocheMain();
                    break;
                case "7":
                    Ex7Persona.TestPersona();
                    break;
                case "8":
                    Password.TestPassword();
                    break;
                case "9":
                    Electrodomestico.TestElectrodomestico();
                    break;
                case "10":
                    Serie.TestSerie();
                    break;
                default:
                    Console.WriteLine("ERROR: Debes introducir un número del 1 al 10.");
                    SelectorEjercicio(); // llamamos otra vez al selector.
                    break;
            }


            // comprobamos si queres ejecutar más ejercicios
            Console.WriteLine("\n \n ¿Quieres comprobar otra vez algún ejercicio? si || no ");
            string salir = Console.ReadLine();

            if (salir == "si") { Console.Clear(); SelectorEjercicio(); }
            else System.Environment.Exit(1);
        }
    }
}
