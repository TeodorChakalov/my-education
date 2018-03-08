using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if(Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    result.Add(number);
                }
            }
            result.Sort();
            result.Reverse();
            //result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}