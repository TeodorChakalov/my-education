using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var weight = double.Parse(Console.ReadLine());

            var lenghtNet = 2 * length + 2 * width;
            var priceNet = lenghtNet * price;
            var areaNet = lenghtNet * height;
            var weightNet = areaNet * weight;

            Console.WriteLine("{0}",lenghtNet);
            Console.WriteLine("{0:F2}", priceNet);
            Console.WriteLine("{0:F3}", weightNet);
        }
    }
}
