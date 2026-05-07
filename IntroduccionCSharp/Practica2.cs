using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCSharp.Models
{
    class Practica2
    {
        String nombre;
        private int edad;
        protected String carrera;

        public void ingresarDatos()
        {
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu carrera: ");
            carrera = Console.ReadLine();
        }

        public void mostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
        }

        public void Main(String[] args)
        {
            Practica2 p2 = new Practica2();
            p2.ingresarDatos();
            p2.mostrarDatos();
        }
    }
}
