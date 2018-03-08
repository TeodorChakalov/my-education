using System;

namespace _3.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);

            //var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //var text = Console.ReadLine();
            // for(var word in bannedWords)
            // {
            //      int startIndex = text.IndexOf(word);
            //      int wordLength = word.length;
            //      string oldValue = text.Substring(startIndex, wordLength);
            //      string newValue = new string('*', word.Length);
            //      text = text.Replace(oldValue, newValue);
            // }
            // console.WriteLine(text);
        }
    }
}