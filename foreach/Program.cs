class Program {
    static void Main(string[] args) {
        // foreach loop
        // a simpler way to iterate over an array,
        // but it's less flexible.

        string[] cars = {"BMW", "Mustang" ,"Corvette"};

        foreach (string car in cars) {
            Console.WriteLine(car);
        }

        /* Estructura básica del foreach

        foreach(var item in collection){
        // espacio al dato dentro del vector o array
        // Dentro del vector sabemos que hay un string,
        // Luego el nombre del vector
        }
        Le estamos diciendo que recorra el vector y que
        a cada objeto o a cada string del array le del nombre
        car.
        */
    }
}