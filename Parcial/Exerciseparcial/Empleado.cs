using ExerciseParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciseparcial
{
    public class Empleado : Persona, ICalculable
    {
        public decimal Salario { get; set; }

        // Constructorque inicia datos empleado
        public Empleado(string nombre, int edad, string direccion, decimal salario)
            : base(nombre, edad, direccion)
        {
            this.Salario = salario;
        }

        // Sobrescribe
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Salario: {Salario}");
        }

        // se implementa el emtodo de la interfaz
        public decimal CalcularSalario()
        {
            return Salario;
        }


        public async Task LeerDatosAsync()
        {
            Console.WriteLine("Leyendo datos...");
            await Task.Delay(2000);
            Console.WriteLine("Datos leídos correctamente.");
        }
    }
}
