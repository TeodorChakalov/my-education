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

            var swim = lengthInMetres * timeInSec;
            var swimAdd = Math.Floor(lengthInMetres / 15);
            var swimAdd1 = swimAdd * 12.5;
            var total = swim + swimAdd1;

            if (recordInSec <= total)
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", total - recordInSec);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", total);
            }
        }
    }
}
