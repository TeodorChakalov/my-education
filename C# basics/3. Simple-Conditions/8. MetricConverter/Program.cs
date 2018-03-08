using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var source = Console.ReadLine();
            var dest = Console.ReadLine();

            var mm = 1000;
            var cm = 100;
            var mi = 0.000621371192;
            var inn = 39.3700787;
            var km = 0.001;
            var ft = 3.2808399;
            var yd = 1.0936133;

            if (source == "mm")
            {
                number = number / mm;
            }
            else if (source == "cm")
            {
                number = number / cm;
            }
            else if (source == "mi")
            {
                number = number / mi;
            }
            else if (source == "in")
            {
                number = number / inn;
            }
            else if (source == "km")
            {
                number = number / km;
            }
            else if (source == "ft")
            {
                number = number / ft;
            }
            else if (source == "yd")
            {
                number = number / yd;
            }

            if (dest == "mm")
            {
                number = number * mm;
            }
            else if (dest == "cm")
            {
                number = number * cm;
            }
            else if (dest == "mi")
            {
                number = number * mi;
            }
            else if (dest == "in")
            {
                number = number * inn;
            }
            else if (dest == "km")
            {
                number = number * km;
            }
            else if (dest == "ft")
            {
                number = number * ft;
            }
            else if (dest == "yd")
            {
                number = number * yd;
            }

            Console.WriteLine("{0} {1}", number, dest);
        }
    }
}
