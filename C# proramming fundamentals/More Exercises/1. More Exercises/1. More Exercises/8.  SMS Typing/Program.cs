using System;

namespace _8.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] smsTable = {
            new string[] {" "},
            new string[] { },
            new string[] { "a", "b", "c" },
            new string[] {"d", "e", "f"},
            new string[] { "g", "h", "i" },
            new string[] { "j", "k", "l" },
            new string[] { "m", "n", "o" },
            new string[] { "p", "q", "r", "s" },
            new string[] { "t", "u", "v" },
            new string[] { "w", "x", "y", "z"}
            };

            int number = int.Parse(Console.ReadLine());
            var output = "";

            for (int i = 0; i < number; i++)
            {
                var currentLetter = int.Parse(Console.ReadLine());
                output += smsTable[currentLetter % 10][currentLetter.ToString().Length - 1];
            }
            Console.WriteLine(output);
        }
    }
}