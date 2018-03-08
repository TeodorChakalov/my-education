using System;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        
            while (true)
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    if (number % 2 != 0)
                    {
                        Console.WriteLine("The number is: {0}", Math.Abs(number));
                        break;
                    }
                    else if (number % 2 == 0)
                    {
                        Console.WriteLine("Please write an odd number.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}