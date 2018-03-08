using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var num in array)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, counts[num]);
            }
        }
    }
}