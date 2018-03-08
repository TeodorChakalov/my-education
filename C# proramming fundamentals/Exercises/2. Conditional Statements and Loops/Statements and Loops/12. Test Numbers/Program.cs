using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());
            var total = 0;
            int counter = 0;

            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {   
                    total = total + 3 * (i * j);
                    counter++;
                    if (total >= stopNumber)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", total, stopNumber);
                        return;
                    }                  
                }
            }
            Console.WriteLine("{0} combinations", counter);
            Console.WriteLine("Sum: {0}", total);
        }
    }
}