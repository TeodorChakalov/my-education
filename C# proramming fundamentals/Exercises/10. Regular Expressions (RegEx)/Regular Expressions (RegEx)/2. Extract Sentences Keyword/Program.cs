using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Extract_Sentences_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();

            string[] sentences = input.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = $@"\b{word}\b";

            foreach (var sentence in sentences)
            {
                if(Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}