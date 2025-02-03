class Program
{
    public static void Show(string[] array) {
        for(int i = 0; i < array.Length; i++) {
            Console.WriteLine(array[i]);
        }
    }

    public static int SeqSearch(string[] array, string x) {
        for(int i = 0; i < array.Length; i++) {
            if(array[i] == x) {
                return i;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        /*
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
        

        int[] numbers = new int[] { 23, 53, 2, 19, 67, 21 };
        
        foreach(int num in numbers) {
            Console.WriteLine(num);
        }
        

        string[] pokemons = {"Pikachu", "Bulbasaur", "Squirtle", "Dugtrio"};

        // bubble sort

        bool flag = true;

        for(int i = 0; i < pokemons.Length && flag; i++) {
            flag = false;
            for(int j = 0; j < pokemons.Length -i -1; j++) {
                if(pokemons[j].CompareTo(pokemons[j + 1]) > 0) {
                    string aux = pokemons[j];
                    pokemons[j] = pokemons[j + 1];
                    pokemons[j + 1] = aux;
                    flag = true;
                }
            }
            if(!flag) break;
        }

        Show(pokemons);
        Console.WriteLine($"Está en el índice: {SeqSearch(pokemons, "Squirtle")}");
        */

        

    }
}