using System;
using System.Text.RegularExpressions;

namespace _4.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b(\d{2})(-|.|\/)([A-Z][a-z]{2})(\2)(\d{4})\b";

            Regex regex = new Regex(pattern);

            MatchCollection validDates = Regex.Matches(text, pattern);

            foreach (Match date in validDates)
            {
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", date.Groups[1], date.Groups[3], date.Groups[5]);
            }
        }
    }
}