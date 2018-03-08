using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var evenSum = 0.0;
            var oddSum = 0.0;
            var maxEven = double.MinValue;
            var minEven = double.MaxValue;
            var maxOdd = double.MinValue;
            var minOdd = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > maxEven) maxEven = num;
                    if (num < minEven) minEven = num;
                }
                else
                {
                    oddSum += num;
                    if (num > maxOdd) maxOdd = num;
                    if (num < minOdd) minOdd = num;
                }
            }

            if (n == 0)
            {
                Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin = No, EvenMax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=0, EvenMin = No, EvenMax = No",oddSum, minOdd, maxOdd);
            }
            else if(n > 1)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum, minOdd, maxOdd, evenSum, minEven, maxEven);
            }
        }
    }
}
