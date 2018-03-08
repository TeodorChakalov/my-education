using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var lengthInSm = length * 100;
            var widthInSm = width * 100;

            var widthInSmMinusCoridor = widthInSm - 100;
            var deskPerRow = Math.Floor(widthInSmMinusCoridor / 70);

            var rows = Math.Floor(lengthInSm / 120);

            var countPlaces = deskPerRow * rows - 3;

            Console.WriteLine("{0}", countPlaces);
        }
    }
}
