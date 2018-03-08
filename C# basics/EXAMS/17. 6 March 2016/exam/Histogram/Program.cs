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
            var count1 = 0.0;
            var count2 = 0.0;
            var count3 = 0.0;
            var count4 = 0.0;
            var count5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    count1++;
                }
                else if (number >= 200 & number <= 399)
                {
                    count2++;
                }
                else if (number >= 400 & number <= 599)
                {
                    count3++;
                }
                else if (number >= 600 & number <= 799)
                {
                    count4++;
                }
                else if (number >= 800)
                {
                    count5++;
                }
            }

            Console.WriteLine("{0:F2}%", count1 / n * 100);
            Console.WriteLine("{0:F2}%", count2 / n * 100);
            Console.WriteLine("{0:F2}%", count3 / n * 100);
            Console.WriteLine("{0:F2}%", count4 / n * 100);
            Console.WriteLine("{0:F2}%", count5 / n * 100);
        }
    }
}
