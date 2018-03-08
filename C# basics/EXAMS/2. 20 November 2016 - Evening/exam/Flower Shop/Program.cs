using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var countMagnolii = int.Parse(Console.ReadLine());
            var countZumbuli = int.Parse(Console.ReadLine());
            var countRozi = int.Parse(Console.ReadLine());
            var countKaktusi = int.Parse(Console.ReadLine());
            var priceForGift = double.Parse(Console.ReadLine());

            var sum = countMagnolii* 3.25 + countZumbuli * 4 + countRozi * 3.50 + countKaktusi * 8;

            var tax = 0.05 * sum;
            var profit = sum - tax;

            if (priceForGift - profit > 0)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(priceForGift - profit));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(profit - priceForGift));
            }
        }
    }
}
