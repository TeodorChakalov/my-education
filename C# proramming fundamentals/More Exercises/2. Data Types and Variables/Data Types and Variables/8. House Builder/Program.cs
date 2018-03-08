using System;

namespace _8.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = int.Parse(Console.ReadLine());
            long secondNumber = int.Parse(Console.ReadLine());

            long sum = 0;

            if (firstNumber >= sbyte.MinValue && firstNumber <= sbyte.MaxValue)
            {
                sum = 4 * firstNumber + 10 * secondNumber;
                Console.WriteLine("{0}", sum);
            }
            else
            {
                sum = 10 * firstNumber + 4 * secondNumber;
                Console.WriteLine("{0}", sum);
            }
        }
    }
}