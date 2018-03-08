using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countRolls = int.Parse(Console.ReadLine());
            var countPlat = int.Parse(Console.ReadLine());
            var lepilo = double.Parse(Console.ReadLine());
            var percentDiscount = int.Parse(Console.ReadLine());

            var priceRolls = countRolls * 5.80;
            var pricePlat = countPlat * 7.20;
            var priceLepilo = lepilo * 1.20;
            var priceAll = priceRolls + pricePlat + priceLepilo;
            var priceWithDiscount = priceAll - ((priceAll * percentDiscount) / 100);

            Console.WriteLine("{0:F3}", priceWithDiscount);
        }
    }
}
