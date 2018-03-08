using System;
using System.Linq;

namespace _6.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').Reverse().ToArray();
            Console.WriteLine(string.Join(" ", arr));

            //string[] arr = Console.ReadLine().Split(' ');

            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    string swap = arr[i];
            //    arr[i] = arr[arr.Length - 1 - i];
            //    arr[arr.Length - 1 - i] = swap;
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
        }
    }
}