using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //string[] inputArray = Console.ReadLine().Trim().Split();
        //HashSet<char> firstWord = new HashSet<char>(inputArray[0]);
        //HashSet<char> secondWord = new HashSet<char>(inputArray[1]);
        //if(firstWord.Count == secondWord.Count)
        //{
        //    Console.WriteLine("true");
        //}
        //else
        //{
        //    Console.WriteLine("false");
        //}

        string[] inputArray = Console.ReadLine().Split();
        List<char> firstWord = new List<char>(inputArray[0]);
        List<char> secondWord = new List<char>(inputArray[1]);

        var first = firstWord.Distinct().ToArray();
        var second = secondWord.Distinct().ToArray();

        if (first.Length == second.Length)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}