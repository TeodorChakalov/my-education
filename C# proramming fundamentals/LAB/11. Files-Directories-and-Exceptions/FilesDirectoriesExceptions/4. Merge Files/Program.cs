using System;
using System.IO;

namespace _4.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readFirst = File.ReadAllText("input1.txt").Split();
            string[] readSecond = File.ReadAllText("input2.txt").Split('\r', '\n');

            for (int i = 0; i < readFirst.Length; i++)
            {
                File.AppendAllText("output.txt", readFirst[i] + Environment.NewLine + readSecond[i]);
            }
        }
    }
}