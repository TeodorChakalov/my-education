using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var countRectangleTables = int.Parse(Console.ReadLine());
            var lengthRectangleTables = double.Parse(Console.ReadLine());
            var widthRectangleTables = double.Parse(Console.ReadLine());

            var areaPokrivki = countRectangleTables * (lengthRectangleTables + 2 * 0.30) * (widthRectangleTables + 2 * 0.30);
            var areaKareta = countRectangleTables * (lengthRectangleTables / 2) * (lengthRectangleTables / 2);
            var priceInDollars = areaPokrivki * 7 + areaKareta * 9;
            var priceInLv = priceInDollars * 1.85;

            Console.WriteLine("{0:F2} USD", priceInDollars);
            Console.WriteLine("{0:F2} BGN", priceInLv);
        }
    }
}
