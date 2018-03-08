using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _5.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z]+)([<\|\\])(.*)([<\|\\])([A-Za-z]+)";

            Match matches = Regex.Match(input, pattern);

            string start = matches.Groups[1].Value;
            string end = matches.Groups[5].Value;


            string input2 = Console.ReadLine();
            string pattern2 = $@"{start}(.*?){end}";

            StringBuilder sb = new StringBuilder();
            MatchCollection match = Regex.Matches(input2, pattern2);

            foreach (Match m in match)
            {
                sb.Append(m.Groups[1].Value);
            }

            if(sb.ToString() == string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(sb);
            }
        }
    }
}