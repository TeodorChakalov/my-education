using System;

namespace _3.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();

            foreach (var character in text)
            {
                Console.Write("\\u" + ((int)character).ToString("x4"));
            }
            Console.WriteLine();
        }
    }
}