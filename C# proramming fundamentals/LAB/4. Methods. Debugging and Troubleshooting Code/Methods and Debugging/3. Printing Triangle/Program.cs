using System;

namespace _3.Printing_Triangle
{
    class Program
    {
        static void printUpperPart(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
        static void printDownPart(int number)
        {
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            printUpperPart(number);
            printDownPart(number);
        }
    }
}