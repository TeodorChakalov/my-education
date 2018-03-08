using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            string text = Console.ReadLine();

            while (text != "3:1")
            {
                string[] commandArgs = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs[0] == "merge")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    string concatWords = "";

                    if (startIndex < 0 || startIndex > names.Count - 1)
                    {
                        startIndex = 0;
                    }
                    if (endIndex < 0 || endIndex > names.Count - 1)
                    {
                        endIndex = names.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatWords += names[i];
                    }
                    names.RemoveRange(startIndex, endIndex - startIndex + 1);
                    names.Insert(startIndex, concatWords);

                    //for (int i = startIndex; i <= endIndex; i++)
                    //{
                    //    names.RemoveAt(startIndex);
                    //}
                    //names.Insert(startIndex, concatWords);
                }
                else if (commandArgs[0] == "divide")
                {
                    List<string> wordsPart = new List<string>();

                    int index = int.Parse(commandArgs[1]);
                    int partitions = int.Parse(commandArgs[2]);

                    string word = names[index];
                    names.RemoveAt(index);

                    int parts = word.Length / partitions;
                    var currentPart = "";
                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            currentPart = word.Substring(i * parts);
                            wordsPart.Add(currentPart);
                        }
                        else
                        {
                            currentPart = word.Substring(i * parts, parts);
                            wordsPart.Add(currentPart);
                        }
                    }
                    names.InsertRange(index, wordsPart);
                }

                text = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}