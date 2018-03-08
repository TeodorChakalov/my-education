using System;

namespace _12.Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}