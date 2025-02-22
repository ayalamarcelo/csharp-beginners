class Program
{
    public static void Show(int[] arr)
    {   // Array
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) // Si no es el último elemento
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
    }
    public static void InsertionSort(int[] arr)
    {
        int aux;
        int j;

        for (int i = 0; i < arr.Length; i++)
        {
            aux = arr[i];
            j = i - 1;
            while (j >= 0 && arr[j] > aux)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = aux;
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 34, 12, 3, 345, 97 };
        InsertionSort(arr);
        Show(arr);
    }
}