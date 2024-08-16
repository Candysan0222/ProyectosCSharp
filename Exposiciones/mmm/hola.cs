using System.ComponentModel;
using System.Runtime.InteropServices;

namespace mmm
{
    [Serializable]  // Indica que la clase puede ser serializada, lo cual puede 


    // Superclase \\
    public class EmpresaTestil
    {
        public int Id { get; set; }
        public string NameCompany { get; set; }

        [Browsable(false)]  // Indica que la propiedad no debe ser visible en el diseñador
        public int Nit { get; set; }

        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }



        [ComVisible(true)]  // Indica que la clase es visible para COM
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {NameCompany}");
            Console.WriteLine($"Nit: {Nit}");
            Console.WriteLine($"EmailAddress: {EmailAddress}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"PhoneNumber: {PhoneNumber}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Region: {Region}");
            Console.WriteLine($"Postalcode: {PostalCode}");
        }


        public string Description { get; set; }

        [DefaultValue("ropa infantil")]  // Especifica un valor predeterminado para la propiedad lo cual el v
        public string Category { get; set; }

        [Category("camisa, blusa, interior, pantalon, falda")]  // Especifica la categoría de la propiedad
        public string Type { get; set; }



        [Obsolete("Usa EmailAddress en lugar de esta propiedad.")]
        public string OldEmailAddress { get; set; }  // Ejemplo de propiedad obsoleta



        [NonSerialized]  // Indica que este campo no debe ser serializado
        private string internalData;


    }

    public class SedeNeiva : EmpresaTestil
    {
        public int id { get; set; }
        public string HeadquartersName { get; set; }



        class Program
        {
            static void Main(string[] args)
            {
                // Crear una instancia de TiendaRopa con datos de ejemplo
                SedeNeiva tienda = new SedeNeiva
                {
                    Id = 1,
                    HeadquartersName = "Tienda de Ropa XYZ",
                    Description = "Venta de ropa para todas las edades y clases de personas",
                    Category = "Ropa infantil, deportiva, interior",
                    Type = "Minorista",
                    Nit = 123456789,
                    EmailAddress = "contacto@tiendaderopa.xyz",
                    Address = "123 Calle Principal",
                    PhoneNumber = "555-1234",
                    City = "Bogotá",
                    Region = "Cundinamarca"
                };

                // Llamar al método DisplayInfo para mostrar la información de la tienda
                tienda.DisplayInfo();
            }
        }
    }
}
