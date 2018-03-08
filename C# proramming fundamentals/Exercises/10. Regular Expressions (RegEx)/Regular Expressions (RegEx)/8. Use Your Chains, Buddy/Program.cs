using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _8.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string HTMLtext = Console.ReadLine();

            string pattern = @"<p>(.+?)<\/p>";
            MatchCollection matches = Regex.Matches(HTMLtext, pattern);

            string currentMatch = string.Empty;

            foreach (Match match in matches)
            {
                currentMatch += match.Groups[1].Value;
            }

            currentMatch = Regex.Replace(currentMatch, @"[^a-z0-9]", " ");
            currentMatch = Regex.Replace(currentMatch, @"\s+", " ");

            StringBuilder sb = new StringBuilder();

            foreach (char ch in currentMatch)
            {
                char currentChar = ch;

                if (ch >= 'a' && ch <= 'm')
                {
                    currentChar = (char)(ch + 13);
                }

                else if (ch >= 'n' && ch <= 'z')
                {
                    currentChar = (char)(ch - 13);
                }

                sb.Append(currentChar);
            }

            Console.WriteLine(sb);
        }
    }
}