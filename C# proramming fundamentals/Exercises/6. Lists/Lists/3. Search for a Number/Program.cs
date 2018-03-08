using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> commandArgs = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int elementsToTake = commandArgs[0];
            int elementsToDelete = commandArgs[1];
            int elementsToContain = commandArgs[2]; 

            for (int i = 0; i < elementsToTake; i++)
            {
                result.Add(numbers[i]);
            }
            for (int i = 0; i < elementsToDelete; i++)
            {
                result.RemoveAt(0);
            }
            for (int i = 0; i < result.Count; i++)
            {
                if(result[i] == elementsToContain)
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");

            //if (numbers.Take(commandArgs[0]).Skip(commandArgs[1]).Contains(commandArgs[2]))
            //{
            //    Console.WriteLine("YES!");
            //}
            //else
            //{
            //    Console.WriteLine("NO!");
            //}
            //-------------------------------------------------------------------------
            //List<int> result = new List<int>();
            //result = numbers.Take(commandArgs[0]).ToList();
            //result.RemoveRange(0, commandArgs[1]);

            //if (result.Contains(commandArgs[2]))
            //{
            //    Console.WriteLine("YES!");
            //}
            //else
            //{
            //    Console.WriteLine("NO!");
            //}

            //Console.WriteLine(result.Contains(commandArgs[2]) ? "YES!" : "NO!");
        }
    }
}