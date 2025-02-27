﻿using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // create and assign integral number variables
            short orange = 6;
            int apple = 300 * orange;
            int strawberry = 4 + apple;
            long banana = 5L + 8L;

            // Prints the integrals number variables
            Console.WriteLine(apple);
            Console.WriteLine(strawberry);
            Console.WriteLine(banana);

            // Create and assign character variables
            char heart = '\u2764';
            char star = '\u2605';
            char dead = '\u2620';

            // Prints the character variables
            Console.WriteLine(heart);
            Console.WriteLine(star);
            Console.WriteLine(dead);


            // Create and assign decimal numbers variables
            decimal black = 1.6m;
            float white = 12435.55f * 512425.24724646f; 
            double brown = 1.88 * 3.5555;

            // Prints decimal numbers variables
            Console.WriteLine(black);
            Console.WriteLine(white);
            Console.WriteLine(brown);

            // Create booleans 
            bool flatearthers = true;
            bool jesus = false;

            // Print the booleans
            Console.WriteLine(flatearthers);
            Console.WriteLine(jesus);


        }
    }
}
