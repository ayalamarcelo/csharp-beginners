class Program
{
    struct Students()
    {

        public int Age;
        public string Name;
        public string LastName;

        public string Students()
        {
            return "Se ha registrado un nuevo alumno";
        }
        // Constructor parametrizado

        public Students(int age, string name, string lastname)
        {
            Age = age;
            Name = name;
            LastName = lastname;
        }
    }
    static void Main(string[] args)
    {
        // Struct = es un tipo de dato que permite agrupar
        //          varios valores de diferentes tipos en un
        //          solo objeto.
        // Es similar a una clase.

        // Crear variable tipo Estudiantes siendo esta un struct
        // Constructor por defecto
        Students student = new Students(34, "Marcelo", "Ayala"); // Agregamos una instancia del struct

        //Students student;

        // student.Age = 34;
        // student.Name = "Jon";
        // student.LastName = "Doe";

        Console.WriteLine($"El nombre del estudiante es {student.Name}");



    }
}