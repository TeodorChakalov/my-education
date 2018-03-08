using System;
using System.Linq;

namespace _5.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = text.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", result));

        }
    }
}