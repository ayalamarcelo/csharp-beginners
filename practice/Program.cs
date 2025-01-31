class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Extensión de su array: ");
        string extInput = Console.ReadLine(); // Lee la entrada del usuario como string
        int ext = int.Parse(extInput); // Convierte la entrada a entero

        string[] array = new string[ext]; // Crea un array de strings de tamaño 'ext'

        for (int i = 0; i < ext; i++)
        {
            Console.WriteLine($"Ingrese el valor para el índice {i}:");
            array[i] = Console.ReadLine(); // Lee cada valor de tipo string y lo guarda en el array
        }

        Console.WriteLine("Contenido del array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Índice {i}: {array[i]}"); // Muestra cada valor del array
        }
    }
}