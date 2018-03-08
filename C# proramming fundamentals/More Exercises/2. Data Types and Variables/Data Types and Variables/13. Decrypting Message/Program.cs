using System;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte number = byte.Parse(Console.ReadLine());
            string text = "";

            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                text += (char)(letter + key);
            }
            Console.WriteLine("{0}", text);
        }
    }
}