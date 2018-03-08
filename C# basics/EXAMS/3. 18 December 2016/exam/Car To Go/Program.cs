using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_To_Go
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
                if (season == "Summer")
                {
                    Console.WriteLine("Economy class");
                    price = 0.35 * budget;
                    Console.WriteLine("Cabrio - {0:F2}", price);
                }
                if (season == "Winter")
                {
                    Console.WriteLine("Economy class");
                    price = 0.65 * budget;
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Compact class");
                    price = 0.45 * budget;
                    Console.WriteLine("Cabrio - {0:F2}", price);
                }
                if (season == "Winter")
                {
                    Console.WriteLine("Compact class");
                    price = 0.80 * budget;
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
            }
            else if (budget > 500)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Luxury class");
                    price = 0.9 * budget;
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
                if (season == "Winter")
                {
                    Console.WriteLine("Luxury class");
                    price = 0.9 * budget;
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
            }

        }
    }
}
