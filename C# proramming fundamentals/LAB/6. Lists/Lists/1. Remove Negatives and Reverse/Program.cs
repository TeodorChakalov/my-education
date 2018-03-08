using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            listOfIntegers.Reverse();

            foreach (var integer in listOfIntegers.ToList())
            {
                if(integer < 0)
                {
                    listOfIntegers.Remove(integer);
                }
            }

            if(listOfIntegers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", listOfIntegers));
            }
        }
    }
}