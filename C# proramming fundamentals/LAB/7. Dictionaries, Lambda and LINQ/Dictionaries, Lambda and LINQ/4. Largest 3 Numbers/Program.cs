using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> biggestThreeNumbers = numbers.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(", ",biggestThreeNumbers));
        }
    }
}