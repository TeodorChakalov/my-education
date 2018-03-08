using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaHome = double.Parse(Console.ReadLine());
            var countWindows = int.Parse(Console.ReadLine());
            var styrofoam = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var areaHomeWithoutAreaWindows = areaHome - countWindows * 2.4;
            var add = areaHomeWithoutAreaWindows + 0.1 * areaHomeWithoutAreaWindows;
            var necessaryPackets = Math.Ceiling(add / styrofoam);
            var needMoney = necessaryPackets * price;

            if (needMoney <= budget)
            {
                Console.WriteLine("Spent: {0:F2}", needMoney);
                Console.WriteLine("Left: {0:F2}", budget - needMoney);
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}", needMoney - budget);
            }
        }
    }
}
