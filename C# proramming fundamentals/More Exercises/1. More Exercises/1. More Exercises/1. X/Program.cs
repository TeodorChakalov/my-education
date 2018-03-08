using System;

namespace _1.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number/2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', number - 2 - 2 * i));
            }

            Console.WriteLine("{0}x{0}", new string(' ', number/2));

            var firstWhiteSpace = number / 2 - 1;
            for (int i = 0; i < number / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', firstWhiteSpace), new string(' ', number - 2 - 2 * firstWhiteSpace));
                firstWhiteSpace--;
            }
        }
    }
}