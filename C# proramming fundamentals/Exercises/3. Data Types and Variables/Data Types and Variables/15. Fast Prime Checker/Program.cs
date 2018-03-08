using System;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;
                for (int delimiter = 2; delimiter <= Math.Sqrt(currentNumber); delimiter++)
                {
                    if (currentNumber % delimiter == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", currentNumber, isPrime);
            }
        }
    }
}