using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceWiskey = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var vine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var wiskey = double.Parse(Console.ReadLine());

            var priceRakia = priceWiskey / 2;
            var priceVine = priceRakia - (0.4 * priceRakia);
            var priceBeer = priceRakia - (0.8 * priceRakia);
            var sumRakia = rakia * priceRakia;
            var sumVine = vine * priceVine;
            var sumBeer = beer * priceBeer;
            var sumWiskey = wiskey * priceWiskey;

            var sum = sumRakia + sumVine + sumBeer + sumWiskey;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
