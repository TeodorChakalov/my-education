using System;
using System.Text.RegularExpressions;

namespace _6.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<a href=""(.+)"">(.+)</a>";

            while (text != "end")
            {
                string replacement = @"[URL href=""$1""]$2[/URL]";

                string result = Regex.Replace(text, pattern, replacement);
                Console.WriteLine(result);

                text = Console.ReadLine();
            }
        }
    }
}