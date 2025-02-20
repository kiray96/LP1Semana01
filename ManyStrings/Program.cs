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
        }
    }
}
