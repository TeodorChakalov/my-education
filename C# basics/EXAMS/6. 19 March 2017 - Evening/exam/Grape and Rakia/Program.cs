using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaVineyard = double.Parse(Console.ReadLine());
            var kg = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());

            var grape = areaVineyard * kg;
            var remainGrape = grape - brak;

            var forRakia = 0.45 * remainGrape;
            var litraRakia = forRakia / 7.5;
            var income = litraRakia * 9.80;

            var sale = 0.55 * remainGrape;
            var incomeGrape = sale * 1.5;

            Console.WriteLine("{0:F2}", income);
            Console.WriteLine("{0:F2}", incomeGrape);
        }
    }
}
