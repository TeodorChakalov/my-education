using System;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", number, multiplier, number * multiplier);
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
                }
            }
        }
    }
}