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
            var n = double.Parse(Console.ReadLine());
            var divideBy2 = 0.0;
            var divideBy3 = 0.0;
            var divideBy4 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    divideBy2++;
                }
                if (num % 3 == 0)
                {
                    divideBy3++;
                }
                if(num % 4 == 0)
                {
                    divideBy4++;
                }
            }

            var p1 = divideBy2 / n * 100;
            var p2 = divideBy3 / n * 100;
            var p3 = divideBy4 / n * 100;

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
        }
    }
}
