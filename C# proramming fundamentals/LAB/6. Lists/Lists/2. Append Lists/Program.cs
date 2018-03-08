using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Append_Lists
{
    class Program
    {
        private static object s;

        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(s => string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)))
                .ToList();

            foreach (var innerList in list)
            {
                Console.Write(string.Join(" ", innerList + " "));
            }
            //List<string> tokens = Console.ReadLine().Split('|').ToList();
            //tokens.Reverse();
            //List<string> result = new List<string>();

            //foreach (var item in tokens)
            //{
            //    List<string> numbers = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //    result.AddRange(numbers);
            //}
            //Console.WriteLine(string.Join(" ", result));
            // --------------------------------------------------------------------------------------
            //string[] tokens = Console.ReadLine().Split('|');
            //List<int> result = new List<int>();

            //for (int i = tokens.Length - 1; i >= 0; i--)
            //{
            //    int[] elements = tokens[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    result.AddRange(elements);
            //}
            //Console.WriteLine(string.Join(" ", result));
        }
    }
}