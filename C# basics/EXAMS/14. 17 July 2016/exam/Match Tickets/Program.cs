using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var countPeople = int.Parse(Console.ReadLine());

            var money = 0.0;
            var price = 0.0;

            if(category == "Normal")
            {
                money = 249.99;
            }
            else if(category == "VIP")
            {
                money = 499.99;
            }

            if (countPeople >= 1 && countPeople <= 4)
            {
                price = 0.75 * budget;
            }
            else if (countPeople >= 5 && countPeople <= 9)
            {
                price = 0.60 * budget;
            }
            else if (countPeople >= 10 && countPeople <= 24)
            {
                price = 0.50 * budget;
            }
            else if (countPeople >= 25 && countPeople <= 49)
            {
                price = 0.40 * budget;
            }
            else if (countPeople >= 50)
            {
                price = 0.25 * budget;
            }

            var remainMoney = budget - price;
            var priceForCategory = money * countPeople;

            if(priceForCategory <= remainMoney)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", remainMoney - priceForCategory);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", priceForCategory - remainMoney);
            }
        }
    }
}
