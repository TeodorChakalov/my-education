using System;
using System.Linq;

namespace _7.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = new int[numbers.Length - 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] += numbers[i] + numbers[i + 1];
            }
            Console.WriteLine(result);
        }
    }
}