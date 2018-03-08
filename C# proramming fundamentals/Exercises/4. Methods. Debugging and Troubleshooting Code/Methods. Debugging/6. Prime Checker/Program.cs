using System;

namespace _6.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            var result = IsPrime(number);
            Console.WriteLine(result);
        }

        static bool IsPrime(long number)
        {
            if (number == 0) return false;
            else if (number == 1) return false;
            else if (number == 2) return true;

            var isPrime = true;
            for (long currentNumber = 3; currentNumber <= Math.Sqrt(number); currentNumber++)
            {
                if(number % currentNumber == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
            //var isPrime = true;
            //for (long i = 2; i <= number; i++)
            //{
            //    isPrime = true;
            //    for (long divider = 2; divider <= Math.Sqrt(number); divider++)
            //    {
            //        if(i % divider == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //}
            //return isPrime;
        }
    }
}