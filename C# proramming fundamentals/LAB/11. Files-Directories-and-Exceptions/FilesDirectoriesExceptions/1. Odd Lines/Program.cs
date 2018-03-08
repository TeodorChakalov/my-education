using System;
using System.IO;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");
            string[] result = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if(i % 2 != 0)
                {
                    result[i] += text[i];
                }
                File.WriteAllLines("output.txt", result);
            }

        }
    }
}