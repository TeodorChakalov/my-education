using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Years_Eve_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var countGuests = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());
            var remainMoney = 0.0;
            var price = countGuests * 20;
            if(price < budget)
            {
                remainMoney = budget - price;
                var priceForFireworks = 0.4 * remainMoney;
                var priceForDonation = remainMoney - priceForFireworks;
                Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation.", Math.Round(priceForFireworks), Math.Round(priceForDonation));
            }
            else
            {
                remainMoney = price - budget;
                Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more.", Math.Round(remainMoney));
            }
        }
    }
}
