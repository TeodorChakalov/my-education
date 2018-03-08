using System;

namespace _8.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= 2 * number; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}