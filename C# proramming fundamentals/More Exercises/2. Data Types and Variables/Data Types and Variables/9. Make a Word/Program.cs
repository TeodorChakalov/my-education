using System;

namespace _9.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = "";

            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                text += letter;
            }
            Console.WriteLine("The word is: {0}", text);
        }
    }
}