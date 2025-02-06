class Program
{
    public struct Socio {
        public int codigo;
        public int categoria;
        public int edad;
        public int ingreso;
        public string nombre;

    }

    static void ingresoDatos(ref Socio datoSocio) {

        Console.WriteLine("Ingrese su código: ");
        datoSocio.codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su categoría: ");
        datoSocio.categoria = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su edad: ");
        datoSocio.edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su año de ingreso al club: ");
        datoSocio.ingreso = int.Parse(Console.ReadLine());        

        Console.WriteLine("Ingrese su nombre: "); 
        datoSocio.nombre = Console.ReadLine(); 

        Console.WriteLine();     
    }

    static void mostrarDatos(ref Socio datoSocio) {
        Console.WriteLine($"Código del socio: {datoSocio.codigo}");
        Console.WriteLine($"Categoría del socio: {datoSocio.categoria}");
        Console.WriteLine($"Edad del socio: {datoSocio.edad}");
        Console.WriteLine($"Año de ingreso del socio: {datoSocio.ingreso}");
        Console.WriteLine($"Nombre del socio: {datoSocio.nombre}");
    }

    static void Main(string[] args)
    {
        Socio datoSocio = new Socio();
        ingresoDatos(ref datoSocio);
        mostrarDatos(ref datoSocio);
    }
}