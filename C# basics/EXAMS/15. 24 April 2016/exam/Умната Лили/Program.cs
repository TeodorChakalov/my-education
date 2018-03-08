using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceLaundry = double.Parse(Console.ReadLine());
            var priceForToy = int.Parse(Console.ReadLine());
            var remainMoney = 0.0;
            var sum = 0.0;
            var counter = 0;
            var counterBrother = 0;
            var money = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    remainMoney += 10;
                    sum += remainMoney; 
                    counterBrother++;
                }
                else
                {
                    counter++;
                }
            }
            money = sum + counter * priceForToy - counterBrother * 1;

            if (money >= priceLaundry)
            {
                Console.WriteLine("Yes! {0:F2}", money - priceLaundry);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", priceLaundry - money);
            }
        }
    }
}
