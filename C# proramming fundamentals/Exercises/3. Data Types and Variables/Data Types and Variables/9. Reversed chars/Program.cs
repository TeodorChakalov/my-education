using System;

namespace _9.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", thirdLetter, secondLetter, firstLetter);
        }
    }
}