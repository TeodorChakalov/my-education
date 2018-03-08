using System;

namespace _8.Greater_of_Two_Values
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else return second;
        }

        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else return second;
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else return second;
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if(type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if(type == "char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }
    }
}