using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] commandArgs = command.Split(' ');

                switch (commandArgs[0])
                {
                    case "add":
                        int index = int.Parse(commandArgs[1]);
                        int element = int.Parse(commandArgs[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        int index1 = int.Parse(commandArgs[1]);
                        //List<int> elements = commandArgs.Skip(2).Select(int.Parse).ToList();
                        List<int> elements = new List<int>();
                        for (int i = 2; i < commandArgs.Length; i++)
                        {
                            elements.Add(int.Parse(commandArgs[i]));
                        }
                        numbers.InsertRange(index1, elements);
                        break;
                    case "contains":
                        int number = int.Parse(commandArgs[1]);
                        Console.WriteLine(numbers.IndexOf(number));
                        break;
                    case "remove":
                        int index2 = int.Parse(commandArgs[1]);
                        numbers.RemoveAt(index2);
                        break;
                    case "shift":
                        int position = int.Parse(commandArgs[1]);
                        for (int i = 0; i < position; i++)
                        {
                            int lastDigit = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = lastDigit;
                        }
                        break;
                    case "sumPairs":

                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                        //List<int> result = new List<int>();
                        //for (int i = 0; i < numbers.Count - 1; i+=2)
                        //{
                        //    numbers[i] += numbers[i+1];
                        //}
                        //for (int i = 1; i < numbers.Count; i++)
                        //{
                        //    numbers.RemoveAt(i);
                        //}
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }
    }
}