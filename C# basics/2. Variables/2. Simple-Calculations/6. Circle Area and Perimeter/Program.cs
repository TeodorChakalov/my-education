using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var perimeter = 2 * Math.PI * r;
            var area = Math.PI * r * r;
            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.WriteLine("Area: {0}", area);
        }
    }
}
