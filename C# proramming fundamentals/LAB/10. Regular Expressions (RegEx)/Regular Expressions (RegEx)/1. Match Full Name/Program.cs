using System;
using System.Text.RegularExpressions;

namespace _1.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            MatchCollection matchNames = Regex.Matches(text, pattern);

            foreach (Match name in matchNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}