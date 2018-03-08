using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_price
{
    class Program
    {
        static void Main(string[] args)
        {
            var theSmallestRoom = double.Parse(Console.ReadLine());
            var areaKitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var secondRoom = theSmallestRoom + 0.1 * theSmallestRoom;
            var thirdRoom = secondRoom + 0.1 * secondRoom;
            var bathRoom = theSmallestRoom / 2;

            var allArea = theSmallestRoom + areaKitchen + secondRoom + thirdRoom + bathRoom;
            var allareWithKoridor = allArea + 0.05 * allArea;

            var allPrice = allareWithKoridor * price;

            Console.WriteLine("{0:F2}", allPrice);
        }
    }
}
