using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            var recordInSec = double.Parse(Console.ReadLine());
            var lengthInMetres = double.Parse(Console.ReadLine());
            var timeInSec = double.Parse(Console.ReadLine());

            var allLength = lengthInMetres * timeInSec;
            var delay = (Math.Floor(lengthInMetres / 15)) * 12.5;
            var allTime = allLength + delay;
            var difference = allTime - recordInSec;

            if (difference >= 0)
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", difference);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", allTime);
            }
        }
    }
}
