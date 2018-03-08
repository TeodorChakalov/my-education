using System;
using System.Text.RegularExpressions;

namespace _3.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patternDidimon = @"[^A-Za-z-]+";
            string patternBojomon = @"[A-Za-z]+-[A-Za-z]+";

            while (text.Length != 0)
            {

                if (Regex.IsMatch(text, patternDidimon) == false)
                {
                    break;
                }
                else if(Regex.IsMatch(text, patternDidimon))
                {
                    Match matchDidimon = Regex.Match(text, patternDidimon);
                    Console.WriteLine(matchDidimon);
                    text = text.Substring(matchDidimon.Index + matchDidimon.Length);
                }

                if (Regex.IsMatch(text, patternBojomon) == false)
                {
                    break;
                }
                else if(Regex.IsMatch(text, patternBojomon))
                {
                    Match matchBojomon = Regex.Match(text, patternBojomon);
                    Console.WriteLine(matchBojomon);
                    text = text.Substring(matchBojomon.Index + matchBojomon.Length);
                }
            }
        }
    }
}