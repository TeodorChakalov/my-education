using System;

namespace _7.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var itemsToBuy = int.Parse(Console.ReadLine());
            var totalSum = 0.0;

            for (int i = 0; i < itemsToBuy; i++)
            {
                var name = Console.ReadLine();
                var price = double.Parse(Console.ReadLine());
                var count = int.Parse(Console.ReadLine());

                if (count > 1)
                {
                    Console.WriteLine("Adding {0} {1}s to cart.", count, name);
                }
                else
                {
                    Console.WriteLine("Adding {0} {1} to cart.", count, name);
                }

                totalSum += count * price;
                budget -= count * price;
            }

            Console.WriteLine("Subtotal: ${0:F2}", totalSum);

            if(budget >= 0)
            {
                Console.WriteLine("Money left: ${0:F2}", budget);
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:F2} more.", Math.Abs(budget));
            }
        }
    }
}