using System;
using System.Linq;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] resultArray = new int[array.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastDigit = array[array.Length - 1];

                for (int j = array.Length - 1; j >= 1; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastDigit;

                for (int j = 0; j < array.Length; j++)
                {
                    resultArray[j] += array[j];
                }
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}