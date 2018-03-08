using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var degree = rad * 180 / Math.PI;
            Console.WriteLine("Резултатът в градуси е: {0:0}", degree);
        }
    }
}