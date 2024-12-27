using System;
class Program
{
    public static void Main(string[] args)
    {
        // array = a variable that can store multiple values. 

        String[] instruments = new String[4];

        instruments[0] = "Trumpet";
        instruments[1] = "Flute"; 
        instruments[2] = "Drum";
        instruments[3] = "Cymbals";

        for(int i = 0; i < instruments.Length; i++){
            Console.WriteLine(instruments[i]);
            Console.Beep();
        }
    }
}