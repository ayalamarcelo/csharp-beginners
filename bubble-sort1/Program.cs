class Program {

    public static void Show(int[] numbers) {
        for(int i = 0; i < numbers.Length; i++) {
            Console.Write(numbers[i] + ", ");
        }
    }
    public static void Main(string[] args) {
        // Bubble sort

        int[] numbers = {24, 112, 11, 23, 2, 0};
        bool flag = true;

        for(int i = 0; i < numbers.Length && flag; i++) {
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
        
        Show(numbers);
    }
}