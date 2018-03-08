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

            if(season == "Summer")
            {
                if (budget <= 100)
                {
                    price = 0.35 * budget;
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Cabrio - {0:F2}", price);
                }
                else if (budget > 100 && budget <= 500)
                {
                    price = 0.45 * budget;
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Cabrio - {0:F2}", price);
                }
                else if (budget > 500)
                {
                    price = 0.90 * budget;
                    Console.WriteLine("Luxury class");
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
            }

            else if (season == "Winter")
            {
                if (budget <= 100)
                {
                    price = 0.65 * budget;
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
                else if (budget > 100 && budget <= 500)
                {
                    price = 0.80 * budget;
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
                else if (budget > 500)
                {
                    price = 0.90 * budget;
                    Console.WriteLine("Luxury class");
                    Console.WriteLine("Jeep - {0:F2}", price);
                }
            }
        }
    }
}
