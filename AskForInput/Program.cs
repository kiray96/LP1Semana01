using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.XPath;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the player to insert a integral number
            Console.WriteLine("Please insert an integral number?");

            // Read the number of the player
            string number = Console.ReadLine();
            // Ask the player to insert a integral namber
            int numberint = int.Parse(number);


            //Ask the player to insert a real number
            Console.WriteLine("Please insert an real number?");

            // Read the number of the player
            string number2 = Console.ReadLine();
            // Ask the player to insert a real namber
            float numberreal = float.Parse(number2);

            //Sum of the two numbers requested by the player
            float result = numberint + numberreal;

            //Print the result
            Console.WriteLine("The result is: " + result);
             
        }
    }
}