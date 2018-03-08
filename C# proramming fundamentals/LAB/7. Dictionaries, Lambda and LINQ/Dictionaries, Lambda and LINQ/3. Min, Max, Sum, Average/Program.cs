using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                //int number = int.Parse(Console.ReadLine());
                //numbers.Add(number);
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers. Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}