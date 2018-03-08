using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split(new char[] { '@', '-', '!', ':', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var allText = string.Concat(text).ToCharArray();
                string[] result = new string[text.Length];
                string pattern = @"[s*t*a*r*S*T*A*R*]";
                string planetPattern = @"@([A-Za-z]+)\w:([0-9]+)!(A?D?)!(->)([0-9]+)";


                for (int j = 0; j < allText.Length; j++)
                {
                    if (Regex.IsMatch(allText[j].ToString(), pattern))
                    {
                        count++;
                    }
                }

                StringBuilder sb = new StringBuilder();

                for (int k = 0; k < allText.Length; k++)
                {
                    sb.Append((char)(allText[k] - count));
                }

                Match match1 = Regex.Match(sb.ToString(), planetPattern);
                if (Regex.IsMatch(sb.ToString(), planetPattern))
                {
                    if (match1.Groups[3].Value == "A")
                    {
                        Console.WriteLine("Attacked planets: 1");
                        Console.WriteLine("-> {0}", match1.Groups[1].Value);
                    }
                }
            }


        }
    }
}