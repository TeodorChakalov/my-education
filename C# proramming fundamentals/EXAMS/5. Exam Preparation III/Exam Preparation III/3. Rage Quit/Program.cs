using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            List<char> symbols = new List<char>();

            string pattern = @"([^0-9]+)([0-9]+)";

            MatchCollection matches = Regex.Matches(input, pattern);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value;
                int number = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < number; i++)
                {
                    sb.Append(text);
                }
                if (number != 0)
                {
                    symbols.AddRange(text);
                }
            }

            Console.WriteLine("Unique symbols used: {0}", symbols.Distinct().Count());
            Console.WriteLine(sb);

        }
    }
}