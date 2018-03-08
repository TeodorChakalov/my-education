using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());

            switch (projection)
            {
                case "Premiere": Console.WriteLine("{0:F2}", 12 * rows * col); break;
                case "Normal": Console.WriteLine("{0:F2}", 7.5 * rows * col); break;
                case "Discount": Console.WriteLine("{0:F2}", 5 * rows * col); break;
            }
        }
    }
}
