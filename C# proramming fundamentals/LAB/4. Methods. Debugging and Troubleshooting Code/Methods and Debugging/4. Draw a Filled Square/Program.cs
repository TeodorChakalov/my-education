using System;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void printHeaderAndFooterRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        static void printMiddleRows(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < number - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            printHeaderAndFooterRow(number);
            printMiddleRows(number);
            printHeaderAndFooterRow(number);
        }
    }
}