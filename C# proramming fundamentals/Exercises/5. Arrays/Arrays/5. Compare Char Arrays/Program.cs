using System;
using System.Linq;

namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if(firstArr.Length == secondArr.Length)
            {
                if (firstArr[0] < secondArr[0])
                {
                    Console.WriteLine(firstArr);
                    Console.WriteLine(secondArr);
                }
                else
                {
                    Console.WriteLine(secondArr);
                    Console.WriteLine(firstArr);
                }
            }
            else if(firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(secondArr);
                Console.WriteLine(firstArr);
            }
            else
            {
                Console.WriteLine(firstArr);
                Console.WriteLine(secondArr);
            }
        }
    }
}