using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин_за_детски_играчки
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceHoliday = double.Parse(Console.ReadLine());
            var puzzle = int.Parse(Console.ReadLine());
            var speakingDolls = int.Parse(Console.ReadLine());
            var teddyBears = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());

            var sum = puzzle * 2.60 + speakingDolls * 3 + teddyBears * 4.10 + minions * 8.2 + trucks * 2;
            var toysCount = puzzle + speakingDolls + teddyBears + minions + trucks;
            var discount = 0.0;

            if(toysCount >= 50)
            {
                discount = 0.25 * sum;
            }

            var endSum = sum - discount;
            var rent = 0.1 * endSum;
            var earnMoney = endSum - rent;

            var difference = earnMoney - priceHoliday;
            if (difference >= 0)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", difference);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", Math.Abs(difference));
            }
        }
    }
}
