using System;
using System.Linq;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //int k = array.Length / 4;
            //int[] leftArr = array.Take(k).ToArray();
            //int[] middleArr = array.Skip(k).Take(2 * k).ToArray();
            //int[] rightArr = array.Skip(3 * k).Take(k).ToArray();

            //leftArr.Reverse();
            //rightArr.Reverse();

            //int[] result = new int[2 * k];

            //for (int i = 0; i < k; i++)
            //{
            //    result[i] = leftArr[i] + middleArr[i];
            //    result[i + k] = middleArr[i + k] + rightArr[i];
            //}
            //string.Join(" ", result);
            //Console.WriteLine(result);


            int k = array.Length / 4;
            int[] upper = new int[array.Length / 2];
            int[] lower = new int[array.Length / 2];

            for (int i = 0; i < 2 * k; i++)
            {
                lower[i] = array[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                upper[i] = array[k - 1 - i];
                upper[k + i] = array[array.Length - 1 - i];
            }

            int[] result = new int[2 * k];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upper[i] + lower[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}