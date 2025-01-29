class Programa {
    public static void Main(string[] args) {
        // class = A bundle of related code.
        //         Can be used as a blueprint to creat objects(OOP)

        Messages.Hello();
        Messages.Waiting();
    }

    public static class Messages {
        public static void Hello() {
            Console.WriteLine("Hello...!");
        }
        public static void Waiting() {
            Console.WriteLine("I'm waiting for something");
        }
    }
}