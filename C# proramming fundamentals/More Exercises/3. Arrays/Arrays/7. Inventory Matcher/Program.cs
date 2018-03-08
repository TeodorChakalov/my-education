using System;
using System.Linq;

namespace _7.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string product = Console.ReadLine();

            while(product != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if(product == names[i])
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}", names[i], prices[i], quantities[i]);
                    }
                }
                product = Console.ReadLine();
            }
        }
    }
}