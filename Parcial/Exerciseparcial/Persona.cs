using System;

namespace ExerciseParcial
{
    // Clase Persona
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        // Constructor 
        public Persona(string nombre, int edad, string direccion)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Direccion = direccion;
        }

        // Constructor sin parámetros 
        public Persona()
        {
            this.Nombre = "Nadie";
            this.Edad = 0;
            this.Direccion = "Ninguno";
        }

        // Método de informacon
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Su nombre: {Nombre},Su edad: {Edad},Su dirección: {Direccion}");
        }
    }

    
    
}
