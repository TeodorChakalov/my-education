using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var width = Math.Abs(x1 - x2);
            var height = Math.Abs(y1 - y2);

            Console.WriteLine("Area: {0}", width * height);
            Console.WriteLine("Perimeter: {0}", 2 * (width + height));
        }
    }
}