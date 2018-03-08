using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Sum_reverseersed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = Console.ReadLine().Split().Select(e => int.Parse(new string(e.reverse().ToArray()))).Sum();
            //Console.WriteLine(sum);
            //--------------------------------------------------------------------------------
            //List<string> list = Console.ReadLine().Split(' ').ToList();
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    string currentNum = list[i];
            //    string current = "";
            //    for (int j = currentNum.Length - 1; j >= 0; j--)
            //    {
            //        current += currentNum[j];
            //    }
            //    sum += int.Parse(current);
            //}
            //Console.WriteLine(sum);
            // --------------------------------------------------------------------------------
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    int reverse = 0;
            //    while (list[i] > 0)
            //    {
            //        int reminder = list[i] % 10;
            //        reverse = reverse * 10 + reminder;
            //        list[i] = list[i] / 10;
            //    }
            //    sum += reverse;
            //}
            //Console.WriteLine(sum);
            //----------------------------------------------------------------------------------

            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            long sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                char[] array = numbers[i].ToCharArray();
                char[] reversed = array.Reverse().ToArray();
                string reverse = string.Join("", reversed);
                long numFinal = long.Parse(reverse);
                sum += numFinal;
            }
            Console.WriteLine(sum);
        }
    }
}