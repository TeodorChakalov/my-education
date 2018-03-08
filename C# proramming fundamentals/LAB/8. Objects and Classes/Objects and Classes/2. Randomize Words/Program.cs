using System;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(0, words.Length);
                string swap = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = swap;

                //int firstWord = rnd.Next(0, words.Length);
                //int secondWord = rnd.Next(0, words.Length);

                //string swap = words[firstWord];
                //words[firstWord] = words[secondWord];
                //words[secondWord] = swap;
                //-------------------------------------------------------
                //var randomIndex = rnd.Next(0, words.Length);
                //var randomWord = words[randomIndex];

                //var currentWord = words[i];
                //words[i] = randomWord;
                //words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}