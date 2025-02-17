class Program {
    /*
    Una empresa desea calcular las comisiones de ventas de sus empleados. Se posee
    una lista con el número de legajo, apellido, nombre, código de categoría y 
    ventas acumuladas del mes. Un empleado puede pertenecer sólo a una de las siguientes
    categorías "A", "B" o "C". (debe validarse). Se conoce la cantidad de empleados
    antes de comenzar la carga. La comisión se calcula en base a las ventas acumuladas
    y la categoria. El porcentaje de comisión para categoría "A" es de 5%, para "B"
    el 6%, pero si el acumulado superar los 50000, será del 8%, la categoría "C" será
    del 2% para ventas hasta 20000, 4% para ventas hasta 40000 y 7% para las ventas
    superiores.

    Función 1: Carga de los datos de los vendedores.
    Función 2: Listar empleados informando un número de legajo, apellido, nombre, ventas
    acumuladas del mes y el porcentaje de comisión que le corresponde y su monto de comisión.
    Función 3: Ordenar el los arreglos segú´n el volumen de venta, para ello implementar
    un algoritmo de ordenamiento ELEMENTAL.
    Función 4: Obtener el porcentaje de comisión, considerando el monto de venta y categoría
    Función 5: Realizar una búsqueda interactiva para el usuario, ingresando número de
    legajo obtendrá por pantalla toda la información del vendedor, en caso de no existir
    informar 'Venderor inexistente'.
    Función 6: Implementar el algoritmo de búsqueda ELEMENTAL para ser utilizado en función 5.
    */
    public struct Empleado {
        public int legajo;
        public string apellido;
        public string nombre;
        public string categoria;
        public float ventas;
    }
    public static void Main(string[] args) {
        // Array de vendedores
        int cant;
        Console.WriteLine("Ingrese la cantidad de vendedores: ");
        cant = int.Parse(Console.ReadLine());
        Empleado[] vendedores = new Empleado[cant];
        
    }
}