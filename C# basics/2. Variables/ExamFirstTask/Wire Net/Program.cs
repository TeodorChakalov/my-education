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

            var lengthNet = 2 * length + 2 * width;
            var priceNet = lengthNet * price;
            var areaNet = lengthNet * height;
            var weightNet = areaNet * weight;

            Console.WriteLine("{0}",lengthNet);
            Console.WriteLine("{0:F2}", priceNet);
            Console.WriteLine("{0:F3}", weightNet);
        }
    }
}
