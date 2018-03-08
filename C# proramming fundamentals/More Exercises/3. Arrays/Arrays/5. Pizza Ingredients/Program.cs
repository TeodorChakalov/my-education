using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int wordLength = int.Parse(Console.ReadLine());

            int counter = 0;

            List<string> addedIngredients = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Length == wordLength)
                {
                    counter++;
                    addedIngredients.Add(array[i]);
                    Console.WriteLine("Adding {0}.", array[i]);
                }
                if(counter == 10)
                {
                    break;
                }
            }
            Console.WriteLine("Made pizza with total of {0} ingredients.", counter);
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", addedIngredients));
        }
    }
}