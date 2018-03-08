using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шофьор_на_ТИР
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());

            var price = 0.0;

            if(season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000) price = 0.75;
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000) price = 0.95;
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000) price = 1.45;

            }
            else if(season == "Summer")
            {
                if (kmPerMonth <= 5000) price = 0.90;
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000) price = 1.10;
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000) price = 1.45;
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000) price = 1.05;
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000) price = 1.25;
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000) price = 1.45;
            }

            var sale = kmPerMonth * price * 4;
            var saleAfterExpenses = sale - 0.1 * sale;
            Console.WriteLine("{0:F2}", saleAfterExpenses);
        }
    }
}
