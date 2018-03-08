using System;
using System.Linq;

namespace _2.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] commandArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(commandArgs[0] == "reverse")
                {
                    int startIndex = int.Parse(commandArgs[2]);
                    int count = int.Parse(commandArgs[4]);

                    if(startIndex < 0 || startIndex > numbers.Count - 1 || count < 0 || startIndex + count > numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        string[] firstPart = numbers.Take(startIndex).ToArray();
                        string[] reversePart = numbers.Skip(startIndex).Take(count).Reverse().ToArray();
                        string[] secondPart = numbers.Skip(startIndex + count).ToArray();
                        numbers = firstPart.Concat(reversePart).Concat(secondPart).ToList();
                    }
                }

                else if(commandArgs[0] == "sort")
                {
                    int startIndex = int.Parse(commandArgs[2]);
                    int count = int.Parse(commandArgs[4]);

                    if (startIndex < 0 || startIndex > numbers.Count - 1 || count < 0 || startIndex + count > numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        string[] firstPart = numbers.Take(startIndex).ToArray();
                        string[] sortPart = numbers.Skip(startIndex).Take(count).OrderBy(x => x).ToArray();
                        string[] secondPart = numbers.Skip(startIndex + count).ToArray();
                        numbers = firstPart.Concat(sortPart).Concat(secondPart).ToList();
                    }
                }

                else if(commandArgs[0] == "rollLeft")
                {
                    int count = int.Parse(commandArgs[1]);

                    if(count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        count = count % numbers.Count;
                        string[] countElementsToRoll = numbers.Take(count).ToArray();
                        string[] remainElements = numbers.Skip(count).Take(numbers.Count - count).ToArray();
                        numbers = remainElements.Concat(countElementsToRoll).ToList();
                    }
                }

                else if (commandArgs[0] == "rollRight")
                {
                    int count = int.Parse(commandArgs[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        count = count % numbers.Count;
                        string[] remainElements = numbers.Take(numbers.Count - count).ToArray();
                        string[] countElementsToRoll = numbers.Skip(numbers.Count - count).Take(count).ToArray();
                        numbers = countElementsToRoll.Concat(remainElements).ToList();
                    }
                }

                input = Console.ReadLine();
            }
            var result = string.Join(", ", numbers);
            Console.WriteLine("[{0}]", result);
        }
    }
}