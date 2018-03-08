using System;
using System.Linq;

namespace _2.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] reverseArray = arr.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", reverseArray));


            //int[] arr = new int[n];

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(string.Join(" ", arr));
        }
    }
}