using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Sum_reverseersed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bombNumber = bombArgs[0];
            int power = bombArgs[1];

            while (numbers.Contains(bombNumber))
            {
                int position = numbers.IndexOf(bombNumber);
                if(position - power < 0 && position + power > numbers.Count)
                {
                    numbers.Clear();
                }
                else if(position - power < 0)
                {
                    numbers.RemoveRange(0, 1+power + position);
                }
                else if(position + power > numbers.Count - 1)
                {
                    numbers.RemoveRange(position - power, power + 1 + numbers.Count - 1 - position);
                }
                else
                {
                    numbers.RemoveRange(position - power, 2 * power + 1);
                }
            }
            Console.WriteLine(numbers.Sum());


            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if(numbers[i] == bombArgs[0])
            //    {
            //        for (int j = i - bombArgs[1]; j <= i + bombArgs[1]; j++)
            //        {
            //            if (j >= 0 && j <= numbers.Count - 1)
            //            {
            //                numbers[j] = 0;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(numbers.Sum());


            //var sum = 0;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(string.Join(" ", sum));
        }
    }
}