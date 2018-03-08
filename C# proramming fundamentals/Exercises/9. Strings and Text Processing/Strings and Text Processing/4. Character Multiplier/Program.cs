using System;

namespace _4.Character_sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string first = input[0];
            string second = input[1];

            int min = Math.Min(first.Length, second.Length);
            long sum = 0;

            for (int i = 0; i < min; i++)
            {
                sum += first[i] * second[i];
            }
            if (first.Length < second.Length)
            {
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            else if (first.Length > second.Length)
            {
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}