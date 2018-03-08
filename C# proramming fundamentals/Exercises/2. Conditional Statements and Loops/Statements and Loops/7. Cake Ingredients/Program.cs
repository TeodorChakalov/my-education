using System;

namespace _7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var counter = 0;

            while (command != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", command);
                command = Console.ReadLine();
                counter++;
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}