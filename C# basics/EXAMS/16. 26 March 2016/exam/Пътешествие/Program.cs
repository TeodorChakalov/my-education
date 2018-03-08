using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var price = 0.0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    price = 0.3 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = 0.7 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
            else if (budget >= 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    price = 0.40 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = 0.80 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer")
                {
                    price = 0.90 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = 0.90 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
        }
    }
}
