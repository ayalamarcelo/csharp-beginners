class Program {
    public stativ void Main(string[] args) {
        // Pseudo random
        Random random = new Random();

        // int num = random.Next(1, 21); // Si le agrego un + 100
        // double num = random.NextDouble(0, 1);
        // Si quiero tirar 3 dados con 3 datos

        int num1 = random.Next();
        int num2 = random.Next();
        int num3 = random.Next();

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);

        // Me devuelve el random + el número a sumar

    }
}