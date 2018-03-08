using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numberTill200 = 0.0;
            var numberBetween200And399 = 0.0;
            var numberBetween400And599 = 0.0;
            var numberBetween600And799 = 0.0;
            var numberFrom800 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    numberTill200++;
                }
                else if (num >= 200 && num <= 399)
                {
                    numberBetween200And399++;
                }
                else if (num >= 400 && num <= 599)
                {
                    numberBetween400And599++;
                }
                else if (num >= 600 && num <= 799)
                {
                    numberBetween600And799++;
                }
                else if (num >= 800)
                {
                    numberFrom800++;
                }
            }

            var p1 = numberTill200 / n * 100;
            var p2 = numberBetween200And399 / n * 100;
            var p3 = numberBetween400And599 / n * 100;
            var p4 = numberBetween600And799 / n * 100;
            var p5 = numberFrom800 / n * 100;

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
            Console.WriteLine("{0:F2}%", p4);
            Console.WriteLine("{0:F2}%", p5);
        }
    }
}
