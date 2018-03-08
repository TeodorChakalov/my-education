using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Боядисване_на_къща
{
    class Program
    {
        static void Main(string[] args)
        {
            var heigthHouse = double.Parse(Console.ReadLine());
            var lengthSide = double.Parse(Console.ReadLine());
            var heigthCeiling = double.Parse(Console.ReadLine());

            var squareLengthSide = heigthHouse * lengthSide;
            var squareMirror = 1.5 * 1.5;
            var BothSides = 2 * squareLengthSide - 2 * squareMirror;
            var backWall = heigthHouse * heigthHouse;
            var input = 1.2 * 2;
            var backFrontSide = 2 * backWall - input;
            var areaAllSides = BothSides + backFrontSide;
            var greenPaint = areaAllSides / 3.4;

            var bothRectanglesCeiling = 2 * heigthHouse * lengthSide;
            var bothTriangles = 2 * (heigthHouse * heigthCeiling / 2);
            var areaAllCeiling = bothRectanglesCeiling + bothTriangles;
            var redPaint = areaAllCeiling / 4.3;

            Console.WriteLine("{0:F2}", greenPaint);
            Console.WriteLine("{0:F2}", redPaint);
        }
    }
}
