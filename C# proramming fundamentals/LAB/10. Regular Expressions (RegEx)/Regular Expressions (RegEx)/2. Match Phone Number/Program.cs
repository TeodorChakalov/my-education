using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = Regex.Matches(text, pattern);

            //string[] matchesPhones = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            List<string> validPhoneNumbers = new List<string>();
            foreach(Match phone in matches)
            {
                validPhoneNumbers.Add(phone.ToString());
            }
            Console.WriteLine(string.Join(", ", validPhoneNumbers));
        }
    }
}