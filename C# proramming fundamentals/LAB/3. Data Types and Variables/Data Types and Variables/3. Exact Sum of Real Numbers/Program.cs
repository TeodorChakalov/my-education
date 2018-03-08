using System;

namespace _3.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0m;

            for (int i = 0; i < number; i++)
            {
                var currentNumber = decimal.Parse(Console.ReadLine());

                sum += currentNumber;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}