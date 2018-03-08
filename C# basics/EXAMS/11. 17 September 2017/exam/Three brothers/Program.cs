using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeForFirstBrother = double.Parse(Console.ReadLine());
            var timeForSecondBrother = double.Parse(Console.ReadLine());
            var timeForThirdBrother = double.Parse(Console.ReadLine());
            var timeForFather = double.Parse(Console.ReadLine());

            var totalTime = 1 / (1 / timeForFirstBrother + 1 / timeForSecondBrother + 1 / timeForThirdBrother);
            var onlyBreak = totalTime * 0.15;
            var timeWithBreak = totalTime + onlyBreak;

            if(timeForFather >= timeWithBreak)
            {
                Console.WriteLine("Cleaning time: {0:F2}", timeWithBreak);
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeForFather - timeWithBreak));
            }
            else
            {
                Console.WriteLine("Cleaning time: {0:F2}", timeWithBreak);
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(timeWithBreak - timeForFather));
            }
        }
    }
}
