using System;

namespace _2.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.Contains("."))
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }

            
        }
    }
}