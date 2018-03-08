using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int toSkip = numbers[0];
            int toTake = numbers[1];
            string text = Console.ReadLine();

            string pattern = @"(\|<)(\w{" + toSkip + "})(\\w{0," + toTake + "})";

            MatchCollection match = Regex.Matches(text, pattern);

            List<string> result = new List<string>();
            foreach (Match camera in match)
            {
                result.Add(camera.Groups[3].Value.ToString());
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}