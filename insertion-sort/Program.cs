class Program {

    public static void InsertionSort(int[] arr) {
        int aux;
        int j;

        for(int i = 0; i < arr.Length; i++) {
            aux = arr[i];
            j = i - 1;
            while(j >= 0 && array[j] > aux) {
                arr[j +1] = arr[j];
                j--;
            }
            arr[j + 1] = aux;
        }
    }
    public stativ void Main(string[] args) {

    }
}