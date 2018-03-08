using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceHoliday = double.Parse(Console.ReadLine());
            var countPuzzles = int.Parse(Console.ReadLine());
            var speakingDolls = int.Parse(Console.ReadLine());
            var bears = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());
            var discount = 0.0;

            var sum = countPuzzles * 2.60 + speakingDolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            var countToys = countPuzzles + speakingDolls + bears + minions + trucks;

            if (countToys >= 50)
            {
                discount = 0.25 * sum;

            }
            var endPrice = sum - discount;
            var tax = 0.1 * endPrice;
            var profit = endPrice - tax;

            if (profit >= priceHoliday)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", profit - priceHoliday);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", priceHoliday - profit);
            }
        }
    }
}
