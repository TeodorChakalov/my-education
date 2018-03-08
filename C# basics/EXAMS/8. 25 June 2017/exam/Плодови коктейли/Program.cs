using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var size = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var price = 0.0;

            if(fruit == "Watermelon")
            {
                if(size == "small")
                {
                    price = 2 * 56;
                }
                else if(size == "big")
                {
                    price = 5 * 28.70;
                }
            }
            else if(fruit == "Mango")
            {
                if (size == "small")
                {
                    price = 2 * 36.66;
                }
                else if (size == "big")
                {
                    price = 5 * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = 2 * 42.10;
                }
                else if (size == "big")
                {
                    price = 5 * 24.80;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price = 2 * 20;
                }
                else if (size == "big")
                {
                    price = 5 * 15.20;
                }
            }

            var priceCountCoctails = count * price;

            if (priceCountCoctails >= 400 && priceCountCoctails <= 1000)
            {
                priceCountCoctails = priceCountCoctails - 0.15 * priceCountCoctails;
            }
            else if (priceCountCoctails > 1000)
            {
                priceCountCoctails = priceCountCoctails - 0.50 * priceCountCoctails;
            }

            Console.WriteLine("{0:F2} lv.", priceCountCoctails);
        }
    }
}
