using Exerciseparcial;

class Program
{
    static async Task Main(string[] args)
    {
        Empleado empleado = new Empleado("Juan", 30, "Calle 33D #5p69 Palermo", 2500.50m);
        empleado.MostrarInfo();

        decimal salarioCalculado = empleado.CalcularSalario();
        Console.WriteLine($"Salario calculado: {salarioCalculado:C}");

        await empleado.LeerDatosAsync();
    }
}
