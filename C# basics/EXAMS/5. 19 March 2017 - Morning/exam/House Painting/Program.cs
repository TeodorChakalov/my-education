using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var lengthSide = double.Parse(Console.ReadLine());
            var heightTriangle = double.Parse(Console.ReadLine());

            var areaSide = height * lengthSide;
            var areaWindow = 1.5 * 1.5;
            var areaBothSides = 2 * areaSide - 2 * areaWindow;
            var behindSide = height * height;
            var input = 2 * 1.2;
            var bothFrontBehind = 2 * behindSide - input;
            var allTotal = areaBothSides + bothFrontBehind;
            var green = allTotal / 3.4;
            var ceilingRectangles = 2 * (height * lengthSide);
            var bothTriangles = 2 * (height * heightTriangle / 2);
            var allArea = ceilingRectangles + bothTriangles;
            var red = allArea / 4.3;

            Console.WriteLine("{0:F2}", green);
            Console.WriteLine("{0:F2}", red);
        }
    }
}
