using System;
using System.Linq;

namespace _4.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var isFoundSum = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        isFoundSum = true;
                        Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], sum);
                    }
                }
            }
            if (isFoundSum == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}