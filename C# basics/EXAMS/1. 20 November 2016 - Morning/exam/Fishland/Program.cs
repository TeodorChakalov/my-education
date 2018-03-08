using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceMackerel = double.Parse(Console.ReadLine());
            var priceSprat = double.Parse(Console.ReadLine());
            var pricePalmwood = double.Parse(Console.ReadLine());
            var priceScad = double.Parse(Console.ReadLine());
            var priceClam = double.Parse(Console.ReadLine());

            var allPricePalmwood = priceMackerel + priceMackerel * 0.6;
            var allSumPalmwood = pricePalmwood * allPricePalmwood;

            var allPriceScad = priceSprat + priceSprat * 0.8;
            var allSumScad = priceScad * allPriceScad;

            var allPriceClam = priceClam * 7.5;

            var totalSum = allSumPalmwood + allSumScad + allPriceClam;

            Console.WriteLine("{0:F2}",totalSum);
        }
    }
}
