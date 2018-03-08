using System;

namespace _3.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                int quatitiesOfWater = int.Parse(Console.ReadLine());
                sum += quatitiesOfWater;

                if(sum > byte.MaxValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quatitiesOfWater;
                }
            }
            Console.WriteLine(sum);
        }
    }
}