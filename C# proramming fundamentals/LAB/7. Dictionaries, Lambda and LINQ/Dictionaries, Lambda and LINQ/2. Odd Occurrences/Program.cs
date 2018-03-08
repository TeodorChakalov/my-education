using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().ToLower().Split(' ').ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in array)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }

            List<string> result = new List<string>();
            foreach (var word in dict)
            {
                if(word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}