using System;
using System.Linq;

namespace _5.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                double rounded = Math.Round(arr[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", arr[i], rounded);
            }
        }
    }
}