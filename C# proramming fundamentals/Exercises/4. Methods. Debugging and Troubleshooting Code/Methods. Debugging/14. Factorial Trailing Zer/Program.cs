using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zer
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = GetFaftorial(number);
            BigInteger trailingZeroes = GetTrailingZeroes(factorial);
            Console.WriteLine("{0}", trailingZeroes);
        }

        static BigInteger GetFaftorial(BigInteger number)
        {
            BigInteger factorial = 1;
            for (BigInteger i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        static BigInteger GetTrailingZeroes(BigInteger factorial)
        {
            BigInteger sum = 0;
            while(factorial % 10 == 0)
            {
                factorial /= 10;
                sum++;
            }
            return sum;
        }
    }
}