using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthPageA = double.Parse(Console.ReadLine());
            var heigthHouseB = double.Parse(Console.ReadLine());

            var bothPages = lengthPageA * (lengthPageA / 2) * 2;
            var square = (lengthPageA / 2) * (lengthPageA / 2);
            var triangle = (lengthPageA / 2 * (heigthHouseB - lengthPageA / 2)) / 2;
            var backWall = square + triangle;
            var input = Math.Pow(lengthPageA / 5, 2);
            var frontWall = backWall - input;
            var areaAll = bothPages + backWall + frontWall;
            var greenPaint = areaAll / 3;
            var ceiling = lengthPageA * (lengthPageA / 2) * 2;
            var redPaint = bothPages / 5;

            Console.WriteLine("{0:F2}", greenPaint);
            Console.WriteLine("{0:F2}", redPaint);
        }
    }
}
