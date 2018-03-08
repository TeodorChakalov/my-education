using System;
using System.Text.RegularExpressions;

namespace _1.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(^|(?<=\s))([a-z0-9]+)([.-_]?[a-z-0-9]+?)@([a-z0-9]+)([-][a-z]+)?\.([a-z]+)([.][a-z]+)?";

            Regex regex = new Regex(pattern);

            MatchCollection validEmailAddress = Regex.Matches(text, pattern);

            foreach (Match email in validEmailAddress)
            {
                Console.WriteLine(email);
            }
        }
    }
}