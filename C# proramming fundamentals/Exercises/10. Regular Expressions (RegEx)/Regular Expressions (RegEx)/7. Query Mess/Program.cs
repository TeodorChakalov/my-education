using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _7.Query_Mess
{
    class Program
    {
        public static void Main()
        {
            var pattern1 = @"([^&?]+)=([^&?]+)";
            var pattern2 = @"(%20|\+)+";

            var line = Console.ReadLine();

            while (!line.Equals("END"))
            {
                var matches = Regex.Matches(line, pattern1);

                var dictionary = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    var field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, pattern2, word => " ").Trim();

                    var value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, pattern2, word => " ").Trim();

                    if (!dictionary.ContainsKey(field))
                    {
                        dictionary[field] = new List<string>();
                    }

                    dictionary[field].Add(value);
                }

                foreach (var kvpResult in dictionary)
                {
                    Console.Write($"{kvpResult.Key}=[{string.Join(", ", kvpResult.Value)}]");
                }

                Console.WriteLine();

                line = Console.ReadLine();
            }
        }
    }
}