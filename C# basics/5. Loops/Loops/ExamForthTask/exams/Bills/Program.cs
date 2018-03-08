using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var sumAmperage = 0.0;
            var sumWater = 0.0;
            var sumInternet = 0.0;
            var other = 0.0;

            for (int i = 1; i <= months; i++)
            {
                var billsAmperage = double.Parse(Console.ReadLine());
                sumAmperage += billsAmperage;
            }
            sumWater = months * 20;
            sumInternet = months * 15;
            other = ((sumAmperage + sumWater + sumInternet) + 0.20 * (sumAmperage + sumWater + sumInternet));

            var average = (sumAmperage + sumWater + sumInternet + other) / months;

            Console.WriteLine("Electricity: {0:F2} lv",sumAmperage);
            Console.WriteLine("Water: {0:F2} lv",sumWater);
            Console.WriteLine("Internet: {0:F2} lv",sumInternet);
            Console.WriteLine("Other: {0:F2} lv",other);
            Console.WriteLine("Average: {0:F2} lv",average);
        }
    }
}
