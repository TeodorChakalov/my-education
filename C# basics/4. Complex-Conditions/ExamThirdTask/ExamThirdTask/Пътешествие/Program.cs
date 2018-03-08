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

            double price = 0.0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    price = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    price = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
            else
            {
                if (season == "summer")
                {
                    price = budget * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = budget * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
        }
    }
}
