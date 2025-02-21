using System;
using System.Reflection.PortableExecutable;


namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Ask the player to insert a real number
            Console.WriteLine("Please insert an real number 0 to 1?");

            // Read the number of the player
            string number1 = Console.ReadLine();
            // Ask the player to insert a real number
            float numberreal = float.Parse(number1);

            //Print the result
            //Console.WriteLine(numberreal);

            //Ask the player to insert a real number
            Console.WriteLine("Please insert an real number 0 to 1?");

            // Read the number of the player
            string number2 = Console.ReadLine();
            // Ask the player to insert a real number
            float numberreal1 = float.Parse(number2);

            //Print the result
            //Console.WriteLine(numberreal1);

            //Ask the player to insert a real number
            Console.WriteLine("Please insert an real number 0 to 1?");

            // Read the number of the player
            string number3 = Console.ReadLine();
            // Ask the player to insert a real number
            float numberreal2 = float.Parse(number3);


             //Ask the player to insert a real number
            Console.WriteLine("Please insert an real number 0 to 1?");

            // Read the number of the player
            string number4 = Console.ReadLine();
            // Ask the player to insert a real number
            float numberreal3 = float.Parse(number4);

            //Print the result
            Console.WriteLine("Here we go:");
            Console.WriteLine($" \t {numberreal:p2}");
            Console.WriteLine($" \t {numberreal1:p2}");
            Console.WriteLine($" \t {numberreal2:p2}");
            Console.WriteLine($" \t {numberreal3:p2}");
             

            

        }
    }
}
