﻿using System;
using System.Linq;

namespace _6.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            int[] row1Left = arr.Take(k).Reverse().ToArray();
            int[] row1Right = arr.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();

            int[] result = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                result[i] = row1[i] + row2[i];
            }
            Console.WriteLine(string.Join(" ", result));

            //var sum = row1.Select((x, index) => x + row2[index]);
            //Console.WriteLine(string.Join(" ", sum));
        }
    }
}