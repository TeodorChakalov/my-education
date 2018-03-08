using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            //string pattern = @"\b(?:0x|)[0-9A-F]+\b";
            string pattern = @"\b(0x)?[0-9A-F]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchHexNumbers = Regex.Matches(text, pattern);

            List<string> hex = new List<string>();
            foreach(Match hexNumber in matchHexNumbers)
            {
                hex.Add(hexNumber.ToString());
            }
            Console.WriteLine(string.Join(" ", hex));
        }
    }
}