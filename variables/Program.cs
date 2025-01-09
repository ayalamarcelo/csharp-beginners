class Program {
    public static void Main(string[] args) {
        int x = 24;
        int y = 25;
        int z = x + y;
        
        int age = 21;
        double height = 300.5;
        bool alive = !true;
        char symbol = '@';
        string name = "Marcelo";
        string lastname = "Ayala";
        string username = symbol + name;
        string email = name + lastname + symbol;
        
        Console.Beep();
        Console.WriteLine("Your age is " + age);
        Console.WriteLine("Your height is " + height);
        Console.WriteLine("Are you alive " + alive);
        Console.WriteLine("Your symbol is: " + symbol);
        Console.WriteLine("Username: " + username);
        Console.WriteLine("Your email is: " + email + "gmail.com");
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
}
