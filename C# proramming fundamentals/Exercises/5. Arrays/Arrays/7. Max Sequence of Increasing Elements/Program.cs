using System;
using System.Linq;

namespace _7.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = 0;
            int max = 0;
            int start = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] < array[i + 1])
                {
                    len++;
                    if(len > max)
                    {
                        max = len;
                        start = i - len + 1;
                    }
                }
                else
                {
                    len = 0;
                }
            }
            for (int i = start; i <= start + max; i++)
            {
                Console.Write(array[i] +" ");
            }

        }
    }
}