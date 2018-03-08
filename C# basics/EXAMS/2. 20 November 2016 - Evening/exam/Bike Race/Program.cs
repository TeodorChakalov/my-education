using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var countYoungBikers = int.Parse(Console.ReadLine());
            var countOldBIkers = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine();

            var price = 0.0;

            if(trace == "trail")
            {
                price = countYoungBikers * 5.50 + countOldBIkers * 7;
            }
            else if(trace == "cross-country")
            {
                price = countYoungBikers * 8 + countOldBIkers * 9.50;

                if(countYoungBikers + countOldBIkers >= 50)
                {
                    price = price - 0.25 * price;
                }
            }
            else if(trace == "downhill")
            {
                price = countYoungBikers * 12.25 + countOldBIkers * 13.75;
            }
            else if(trace == "road")
            {
                price = countYoungBikers * 20 + countOldBIkers * 21.50;
            }

            var tax = 0.05 * price;
            var remainMoney = price - tax;

            Console.WriteLine("{0:F2}",remainMoney);
        }
    }
}
