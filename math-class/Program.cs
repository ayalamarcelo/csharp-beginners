class Program {
    public static void Main(string[] args) {

        double x = 3.99;
        double y = 5;

        // double a = Math.Pow(x, 3); // base, exponent 3 x 3 x 3 Potencia
        // double b = Math.Sqrt(x); // square root Raiz
        // double c = Math.Abs(x); // Devuelve el valor absoluto sin signo
        // double d = Math.Round(x); // Redondea hacia el más cercano
        // double e = Math.Ceiling(x); // Redondea hacia arriba al entero cercano
        // double f = Math.Floor(x); // Redondea hacia abajo
        // double g = Math.Max(x, y); // Devuelve el valor Min
        double h = Math.Min(x, y); // Devuelve el valor Max

        Console.WriteLine(h);
    }
}