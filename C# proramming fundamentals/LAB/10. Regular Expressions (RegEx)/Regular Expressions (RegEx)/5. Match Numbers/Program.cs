using System;
using System.Text.RegularExpressions;

namespace _5.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(^|(?<=\s))-?\d+(.\d+)?($|(?=\s))";
            //      (^|(?<=\s)) - positive lookbehind - или започва или задължително преди това има "space"
            //      ($|(?=\s))  - positive lookahead  - или завършва или задължително след това има "space"

            Regex regex = new Regex(pattern);

            MatchCollection validNumbers = Regex.Matches(text, pattern);

            foreach (var number in validNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}