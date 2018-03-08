using System;
using System.IO;
using System.Linq;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = File.ReadAllLines("input.txt");
            //string[] result = new string[lines.Length];

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    result[i] = $"{i+1}. {lines[i]}";
            //    File.WriteAllText("output.txt", result[i]);
            //}

            string[] lines = File.ReadAllLines("input.txt");
            var numberedLines = lines.Select((line, index) => $"{index + 1}. {line}");
            File.WriteAllLines("output.txt", numberedLines);

        }
    }
}