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

            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    Console.Write("Alaska - Camp - ");
                    price = 0.65 * budget;
                    Console.WriteLine("{0:F2}", price);
                }
                if (season == "Winter")
                {
                    Console.Write("Morocco - Camp - ");
                    price = 0.45 * budget;
                    Console.WriteLine("{0:F2}", price);
                }
            }
            else if (budget > 1000 & budget <= 3000)
            {
                if (season == "Summer")
                {
                    Console.Write("Alaska - Hut - ");
                    price = 0.80 * budget;
                    Console.WriteLine("{0:F2}", price);
                }
                if (season == "Winter")
                {
                    Console.Write("Morocco - Hut - ");
                    price = 0.60 * budget;
                    Console.WriteLine("{0:F2}", price);
                }
            }
            else if (budget > 3000)
            {
                if (season == "Summer")
                {
                    Console.Write("Alaska - Hotel - ");
                    price = 0.90 * budget;
                    Console.WriteLine("{0:F2}", price);
                }
                if (season == "Winter")
                {
                    Console.Write("Morocco - Hotel - ");
                    price = 0.90 * budget;
                    Console.WriteLine("{0:F2}", price);
                }
            }
        }
    }
}
