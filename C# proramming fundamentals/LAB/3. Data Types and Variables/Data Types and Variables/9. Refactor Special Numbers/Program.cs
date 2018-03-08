using System;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                var currentDigit = i;
                var sumOfDigits = 0;

                while(currentDigit > 0)
                {
                    sumOfDigits += currentDigit % 10;
                    currentDigit /= 10;
                }
                bool truth = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", i, truth);
            }
        }
    }
}