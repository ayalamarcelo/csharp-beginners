class Program {
    public static int busquedaSecuencial(int[] numbers, int num) {
        bool encontrado = false;
        for(int i = 0; i < numbers.Length; i++) {
            if(numbers[i] == num) {
                return i;
            }
        }
        return -1;
    }

    static void Main(string[] args) {
        int[] temperatura = new int[6] {23, 34, 53, 3, 1, 3};

        /*for(int i = 0; i < 6; i++) {
            Console.WriteLine($"Introduzca el valor {i} del array");
            temperatura[i] = int.Parse(Console.ReadLine());
        }*/

        for(int i = 0; i < temperatura.Length; i++) {
            Console.WriteLine(temperatura[i]);
        }

        Console.WriteLine($"Se encuentra en la posición: {busquedaSecuencial(temperatura, 1)}");

    }
}