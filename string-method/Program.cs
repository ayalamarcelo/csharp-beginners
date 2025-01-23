class Program {
    public static void Main(string[] args) {
        string fullName = "Marcelo Ayala";
        string phoneNumber = "123-456-7890";
        // fullName = fullName.ToUpper();
        // fullName = fullName.ToLower();
        // Console.WriteLine(fullName);
        // phoneNumber.Replace("-","/");
        // Console.WriteLine(phoneNumber);

        // String usernaName = fullName.Insert(0, "Mr. ");
        // Console.WriteLine(usernaName);

        // Console.WriteLine(fullName.Length);

        string firstName = fullName.Substring(0, 8);
        string lastName = fullName.Substring(8,5);
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
    }
}