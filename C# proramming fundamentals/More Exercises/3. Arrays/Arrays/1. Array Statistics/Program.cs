using System;
using System.Linq;

namespace _1.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Count(); 
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }
    }
}