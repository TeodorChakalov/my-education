using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            List<long> quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string product = Console.ReadLine();

            while(quantities.Count < names.Length)
            {
                quantities.Add(0);
            }

            while(product != "done")
            {
                string[] commandArgs = product.Split(' ');

                string nameOfProduct = commandArgs[0];
                long quantity = long.Parse(commandArgs[1]);

                bool flag = false;

                for (int i = 0; i < names.Length; i++)
                {
                    if(nameOfProduct == names[i] && quantity <= quantities[i])
                    {
                        quantities[i] = quantities[i] - quantity;
                        Console.WriteLine("{0} x {1} costs {2:F2}", names[i], quantity, prices[i] * quantity);
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                {
                    Console.WriteLine("We do not have enough {0}", nameOfProduct);
                }

                product = Console.ReadLine();
            }
        }
    }
}