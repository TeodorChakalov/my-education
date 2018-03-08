using System;

namespace _9.Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetSumOddDigits(int number)
        {
            var sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetSumEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number/=10;
            }
            return sum;
        }

        static int GetMultiplyOddEvenDigits(int number)
        {
            int oddDigits = GetSumOddDigits(number);
            int evenDigits = GetSumEvenDigits(number);
            return oddDigits * evenDigits;
        }

        static void Main(string[] args)
        {
            var number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultiplyOddEvenDigits(number);
            Console.WriteLine(result);
        }
    }
}