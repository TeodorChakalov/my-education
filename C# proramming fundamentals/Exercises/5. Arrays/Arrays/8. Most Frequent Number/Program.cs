using System;
using System.Linq;

namespace _8.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = 0;
            int number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (counter > max)
                {
                    max = counter;
                    number = numbers[i];
                }
            }
            Console.WriteLine(number);
        }
    }
}