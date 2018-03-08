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
            var electricity = 0.0;
            var others = 0.0;

            for (int i = 0; i < months; i++)
            {
                var bills = double.Parse(Console.ReadLine());
                electricity += bills;

                others = others + ((bills + 20 + 15) + 0.2 * (bills + 20 + 15));
            }

            var water = months * 20;
            var internet = months * 15;

            //others = (electricity + water + internet) + 0.2 * (electricity + water + internet);

            var average = (electricity + water + internet + others) / months;

            Console.WriteLine("Electricity: {0:F2} lv", electricity);
            Console.WriteLine("Water: {0:F2} lv", water);
            Console.WriteLine("Internet: {0:F2} lv", internet);
            Console.WriteLine("Other: {0:F2} lv", others);
            Console.WriteLine("Average: {0:F2} lv", average);
        }
    }
}
