class Program
{
    public static int secuencial(int[] numbers, int x)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        /*
        array

        string[] ford = { "Mustang", "F-150", "Explorer" };
        string[] chevy = { "Corvette", "Camaro", "Silverado" };
        string[] toyota = { "Corolla", "camry", "Rav4" };

        multidimensional arrays (vectores)

        string[,] parkingLot = { {"Mustang", "F-150", "Explorer"},
                                 {"Corvette", "Camaro", "Silverado"},
                                 {"Corolla", "camry", "Rav4"}
                               };
        parkingLot[0, 2] = "Fusion";

        for (int i = 0; i < parkingLot.GetLength(0); i++)
        {
            for (int j = 0; j < parkingLot.GetLength(1); j++)
            {
              Console.WriteLine(parkingLot[i, j] + " ");
            }
            Console.WriteLine();
        } 
        */

        /* bubble sort

        String[] pokemons = {"Bulbausaur", "Pikachu", "Squirtle", "Abra", "Charmander", "Golem", "Nidorino"};
        
        for(int i = 0; i < pokemons.Length; i++){
            for(int j = i + 1; j < pokemons.Length; j++){
                if(pokemons[i].CompareTo(pokemons[j]) > 0) { // string
                    string aux = pokemons[j];
                    pokemons[j] = pokemons[i];
                    pokemons[i] = aux; 
                }
            }
        }

        for(int i = 0; i < pokemons.Length; i++) {
            Console.WriteLine(pokemons[i]);
        }
        */

        // secuencial

        int[] numbers = { 34, 24, 56, 67, 22 };
        bool swapped;

        for(int i = 0; i < numbers.Length; i++) {
            swapped = false;
            for(int j = i + 1; j < numbers.Length; j++) {
                if(numbers[i] > numbers[j]){
                    int aux = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = aux;
                    swapped = true;
                }
            }
            if(!swapped) break;
        }

        for(int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }

       // Console.WriteLine(secuencial(numbers, 22));

    }
}
