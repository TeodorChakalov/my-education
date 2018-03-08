using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Трима_братя
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = double.Parse(Console.ReadLine());
            var time2 = double.Parse(Console.ReadLine());
            var time3 = double.Parse(Console.ReadLine());
            var time4 = double.Parse(Console.ReadLine());

            var time = 1 / (1 / time1 + 1 / time2 + 1 / time3);
            var Break = time * 0.15;
            var allTime = time + Break;
            var difference = time4 - allTime;

            Console.WriteLine("Cleaning time: {0:F2}", allTime);

            if(difference > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> " + Math.Floor(difference) + " hours.",difference);
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> " + Math.Abs(Math.Floor(difference)) + " hours.", difference);
            }
        }
    }
}