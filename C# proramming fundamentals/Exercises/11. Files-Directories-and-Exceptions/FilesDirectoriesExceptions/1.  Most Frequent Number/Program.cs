using System;
using System.IO;
using System.Linq;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int max = 0;
            string number = "";

            for (int t = 0; t < input.Length; t++)
            {
                string[] text = input[t].Split(' ');
                max = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    int counter = 1;
                    for (int j = i + 1; j < text.Length; j++)
                    {
                        if (text[i] == text[j])
                        {
                            counter++;
                        }
                    }
                    if (counter > max)
                    {
                        max = counter;
                        number = text[i];
                    }
                }
                File.AppendAllText("output.txt", number + Environment.NewLine);
            }
        }
    }
}