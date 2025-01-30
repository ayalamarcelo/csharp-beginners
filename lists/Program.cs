using System;
using System.Collections.Generic;
class Program {
    static void Main(string[] args) {
        /* List = data structure that represents
           a list of objects that can be accessed by
           index. Similar to array, but can dynamically
           increase/decrease in size using
           System.Collections.Generic;
        */
        
        /*
        string[] food = new string[3];
        food[0] = "pizza";
        food[1] = "hamburguer";
        food[2] = "hotdog";
        */

        /* Si quiero agregar:
        food[3] = "fries"; 
        No me lo va a permitir por su extensión
         */

         // importamos System.Collections.Generic;

        List<string> food = new List<string> (); // Declaración de una lista
        food.Add("pizza");
        food.Add("fries");
        food.Add("hamburguer");

        //food.Remove("fries");
        //food.Insert(0, "sushi");

        //Console.WriteLine(food.Count); // Nos muestra la dimensión
        //Console.WriteLine(food.IndexOf("pizza")); // pos
        //Console.WriteLine(food.LastIndexOf("fries"));
        //Console.WriteLine(food.Contains("pizza")); // retorna un booleano
        //food.Sort();
        //food.Reverse();
        //food.Clear(); // empty

        string[] foodArray = food.ToArray();

        /*for(int i = 0; i < food.Count; i++) {
            Console.WriteLine(food[i]);
        }*/
        
    }
}