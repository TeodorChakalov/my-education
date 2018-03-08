using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count2 = 0.0;
            var count3 = 0.0;
            var count4 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count2++;
                }
                if (number % 3 == 0)
                {
                    count3++;
                }
                if (number % 4 == 0)
                {
                    count4++;
                }
            }

            Console.WriteLine("{0:F2}%", count2 / n * 100);
            Console.WriteLine("{0:F2}%", count3 / n * 100);
            Console.WriteLine("{0:F2}%", count4 / n * 100);
        }
    }
}
