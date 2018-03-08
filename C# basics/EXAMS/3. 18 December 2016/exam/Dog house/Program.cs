using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_house
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

            var bothSides = sideA * (sideA / 2) * 2;
            var square = (sideA / 2) * (sideA / 2);
            var triangle = (sideA / 2 * (sideB - sideA/ 2)) / 2;
            var totalSquareTriangle = square + triangle;
            var frontDoor = (sideA / 5) * (sideA / 5);
            var frontSide = totalSquareTriangle - frontDoor;
            var totalArea = bothSides + totalSquareTriangle + frontSide;
            var green = totalArea / 3;
            var ceiling = sideA * (sideA / 2) * 2;
            var red = bothSides / 5;

            Console.WriteLine("{0:F2}",green);
            Console.WriteLine("{0:F2}",red);
        }
    }
}
