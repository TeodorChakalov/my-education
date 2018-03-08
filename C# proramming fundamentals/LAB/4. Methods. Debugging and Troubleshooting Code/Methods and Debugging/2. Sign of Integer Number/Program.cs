using System;

namespace _2.Sign_of_Integer_Number
{
    class Program
    {
        static void positiveNegativeOrZeroNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if(number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            positiveNegativeOrZeroNumber(number);
        }
    }
}