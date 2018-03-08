using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
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
                if (budget <= 1000)
                {
                    price = 0.65 * budget;
                    Console.WriteLine("Alaska - Camp - {0:F2}", price);
                }
                else if (budget > 1000 && budget <= 3000)
                {
                    price = 0.80 * budget;
                    Console.WriteLine("Alaska - Hut - {0:F2}", price);
                }
                else if (budget > 3000)
                {
                    price = 0.90 * budget;
                    Console.WriteLine("Alaska - Hotel - {0:F2}", price);
                }
            }

            else if (season == "Winter")
            {
                if (budget <= 1000)
                {
                    price = 0.45 * budget;
                    Console.WriteLine("Morocco - Camp - {0:F2}", price);
                }
                else if (budget > 1000 && budget <= 3000)
                {
                    price = 0.60 * budget;
                    Console.WriteLine("Morocco - Hut - {0:F2}", price);
                }
                else if (budget > 3000)
                {
                    price = 0.90 * budget;
                    Console.WriteLine("Morocco - Hotel - {0:F2}", price);
                }
            }
        }
    }
}
