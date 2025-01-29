class Program {
    public static int sequential(int[] array, int number) {
        for(int i = 0; i < array.Length; i++) {
            if(array[i] == number) {
                return i;
            }
        }
        return -1;
    }

    public static void bubbleSort(int[] numbers) {
        bool flag;

        for(int i = 0; i < numbers.Length; i++) {
            flag = false;
            for(int j = 0; j < numbers.Length -i - 1; j++) {
                if(numbers[j] > numbers[j + 1]) {
                    int aux = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = aux;
                    flag = true;
                }
            }
            if(!flag) break;
        }
    }

    public static void Show(int[] numbers) {
        for(int i = 0; i < numbers.Length; i++) {
            Console.Write(numbers[i]);
            if( i < numbers.Length -1) {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    public static void Main(string[] args) {
        int[] numbers = new int[6];
        numbers[0] = 34;
        numbers[1] = 14;
        numbers[2] = 2;
        numbers[3] = 90;
        numbers[4] = 10;
        numbers[5] = 5; 
        
        bubbleSort(numbers);
        Show(numbers);
        Console.WriteLine(sequential(numbers, 10));
    }
}