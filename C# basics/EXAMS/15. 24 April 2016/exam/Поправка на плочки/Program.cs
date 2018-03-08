using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthSide = int.Parse(Console.ReadLine());
            var widthTile = double.Parse(Console.ReadLine());
            var lengthTile = double.Parse(Console.ReadLine());
            var widthBench = int.Parse(Console.ReadLine());
            var lengthBench = int.Parse(Console.ReadLine());

            var area = lengthSide * lengthSide;
            var areaBench = widthBench * lengthBench;
            var areaCover = area - areaBench;
            var areaTile = widthTile * lengthTile;
            var necessaryTile = areaCover / areaTile;
            var necessaryTime = necessaryTile * 0.2;

            Console.WriteLine("{0:F2}", necessaryTile);
            Console.WriteLine("{0:F2}", necessaryTime);
        }
    }
}
