using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шивашки_цех
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = int.Parse(Console.ReadLine());
            var lengthTables = double.Parse(Console.ReadLine());
            var widthTables = double.Parse(Console.ReadLine());

            var squareCovers = tables * (lengthTables + 2 * 0.30) * (widthTables + 2 * 0.30);
            var squareBox = tables * Math.Pow(lengthTables / 2, 2);

            var priceInUSD = squareCovers * 7 + squareBox * 9;
            var priceInLv = priceInUSD * 1.85;

            Console.WriteLine("Цената в долари е: {0:F2} USD", priceInUSD);
            Console.WriteLine("Цената в левове е: {0:F2} BGN", priceInLv);
        }
    }
}