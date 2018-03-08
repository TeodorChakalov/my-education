using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();

            foreach (var word in text)
            {
                string reversedWord = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                if (reversedWord.Contains(word)) //&& !list.Contains(word))
                {
                    list.Add(reversedWord);
                }
            }
            
            Console.WriteLine(string.Join(", ", list.Distinct().OrderBy(x => x)));
        }
    }
}