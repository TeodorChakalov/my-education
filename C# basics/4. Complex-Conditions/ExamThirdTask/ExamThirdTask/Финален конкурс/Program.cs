using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Финален_конкурс
{
    class Program
    {
        static void Main(string[] args)
        {
            var dancers = int.Parse(Console.ReadLine());
            var points = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var place = Console.ReadLine();

            var money = dancers * points;
            var moneyAfterCosts = 0.0;

            if (place == "Bulgaria")
            {
                if (season == "summer") moneyAfterCosts = money - 0.05 * money;
                else if (season == "winter") moneyAfterCosts = money - 0.08 * money;
            }
            else if(place == "Abroad")
            {
                money = money + 0.5 * money;
                if (season == "summer") moneyAfterCosts = money - 0.10 * money ;
                else if (season == "winter") moneyAfterCosts = money -  0.15 * money;
            }

            var charity = 0.75 * moneyAfterCosts;
            var remainMoney = moneyAfterCosts - charity;
            var moneyForDancers = remainMoney / dancers;

            Console.WriteLine("Charity - {0:F2}", charity);
            Console.WriteLine("Money per dancer - {0:F2}", moneyForDancers);
        }
    }
}
