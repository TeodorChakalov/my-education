using System;

namespace _6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            if(firstNumber < secondNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = secondNumber; i <= firstNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}