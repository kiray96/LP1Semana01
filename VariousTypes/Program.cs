using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            short orange = 6;
            int apple = 300 * orange;
            int strawberry = 4 + apple;
            long banana = 5L + 8L;

            Console.WriteLine(orange);
            Console.WriteLine(apple);
            Console.WriteLine(strawberry);
            Console.WriteLine(banana);
        }
    }
}
