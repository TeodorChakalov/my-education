using System;
using System.Collections.Generic;

namespace _7.Primes_in_Given_Range
{
    class Program
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> inPrimeRangeList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                var isPrime = true;
                if (i < 2) isPrime = false;
                for (int delimiter = 2; delimiter <= Math.Sqrt(i); delimiter++)
                {
                    if(i % delimiter == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    inPrimeRangeList.Add(i);
                }
            }
            return inPrimeRangeList;

        }
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> result = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}