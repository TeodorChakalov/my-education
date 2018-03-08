using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long sum = 0;
            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long element = 0;
                if(index < 0)
                {
                    element = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if(index > numbers.Count - 1)
                {
                    element = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    element = numbers[index];
                    numbers.RemoveAt(index);
                }

                sum += element;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= element)
                    {
                        numbers[i] += element;
                    }
                    else
                    {
                        numbers[i] -= element;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}