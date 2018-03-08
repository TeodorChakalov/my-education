using System;
using System.Linq;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = 0;
            int max = 0;
            int longestSequenceStart = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] == array[i + 1])
                {
                    len++;
                    if(len > max)
                    {
                        max = len;
                        longestSequenceStart = i - len;
                    }
                }
                else
                {
                    len = 0;
                }
            }
            for (int i = longestSequenceStart + 1; i <= longestSequenceStart + max + 1; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}