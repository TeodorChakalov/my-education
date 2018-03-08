using System;
using System.Linq;

namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", array[i], array[i] - 97);
            }
        }
    }
}