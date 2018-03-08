using System;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static int getFibonacciNumber(int number)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            var result = 0;
            for (int i = 2; i <= number; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = getFibonacciNumber(number);

            if(number == 0 || number == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}