using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Add(0);

            int counter = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], counter);
                    counter = 1;
                }
            }

            //int[] countEqualNums = new int[numbers.Count + 1];

            //foreach (var item in numbers)
            //{
            //    countEqualNums[item]++;
            //}

            //for (int i = 0; i < countEqualNums.Length; i++)
            //{
            //    if (countEqualNums[i] != 0)
            //    {
            //        Console.WriteLine("{0} -> {1}", i, countEqualNums[i]);
            //    }
            //}
        }
    }
}