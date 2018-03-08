using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] placeholder = Console.ReadLine().Split(new char[] {'{', '}'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"([A-Za-z]+)(.+)(\1)";

            MatchCollection matches = Regex.Matches(text, pattern);

            for (int i = 0; i < matches.Count; i++)
            {
                string oldString = matches[i].Groups[2].Value;
                string newString = placeholder[i];
                text = text.Replace(oldString, newString);
            }

            Console.WriteLine(text);

            // ------------------------------------------------------------------------------------------------------------------------
            //string input = Console.ReadLine();

            //StringBuilder modifiedInput = new StringBuilder();

            //modifiedInput.Append(input);

            //string[] values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //if (values.Length == 0)
            //{
            //    Console.WriteLine(input);
            //    return;
            //}

            //string pattern = @"([A-Za-z]+)(.+)(\1)";

            //int index = 0;

            //MatchCollection myMatches = Regex.Matches(input, pattern);

            //foreach (Match match in myMatches)
            //{
            //    modifiedInput.Replace(match.Groups[2].Value, values[index]);
            //    index++;

            //    if (index >= values.Length)
            //    {
            //        index--;
            //    }
            //}

            //Console.WriteLine(modifiedInput);
            //----------------------------------------------------------------------------------------------------------------------------------
            //    string text = Console.ReadLine();

            //    string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            //    string pattern = @"([a-zA-Z]+)(.+)\1";
            //    MatchCollection matches = Regex.Matches(text, pattern);

            //    int placeholderIndex = 0;

            //    foreach (Match match in matches)
            //    {
            //        if (placeholderIndex >= placeholders.Length)
            //        {
            //            break;
            //        }
            //        text = ReplaceFirst(text, match.Groups[2].Value, placeholders[placeholderIndex++]);
            //    }
            //    Console.WriteLine(text);
            //}
            //static string ReplaceFirst(string text, string oldValue, string newValue)
            //{
            //    string substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);
            //    string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);
            //    return substringWithNewValue + text.Substring(substringWithOldValue.Length);
        }
    }
}
