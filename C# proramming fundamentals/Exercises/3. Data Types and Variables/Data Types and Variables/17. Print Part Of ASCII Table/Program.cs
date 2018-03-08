using System;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNumber = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= stopNumber; i++)
            {
                Console.Write("{0} ", (char)i);
            }
            Console.WriteLine();
        }
    }
}