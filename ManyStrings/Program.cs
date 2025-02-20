using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Define strings
            string love = "Please \t give \t me \t a \t 10 \t ! \t ! \t !"; 
            string love2 = "Please, \t please \t give \t me \t a \t 10 \t \u2620 \t \u2620 \t \u2620 \t \u2620";

            // Print strings
            Console.WriteLine(love);
            Console.WriteLine(love2);

            //int for the strings
            int eleven = 12;
            // Define string using concatenation
            string you = "you "; 
            string love3 = you + "can " + "also " + "give " + "me " + "an " + eleven;
            love3 += " maybe?";
            string love4 = $"{you}can also give me an {eleven} maybe?";

            // Print strings
            Console.WriteLine(love3);
            Console.WriteLine(love4);
        }
    }
}
