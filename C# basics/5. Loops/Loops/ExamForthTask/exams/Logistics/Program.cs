using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var countLoads = int.Parse(Console.ReadLine());
            var countTo3 = 0.0;
            var count4To11 = 0.0;
            var countUp12 = 0.0;

            var sum = 0.0;

            for (int i = 0; i < countLoads; i++)
            {
                var tons = int.Parse(Console.ReadLine());

                sum += tons;
                if (tons <= 3)
                {
                    countTo3 +=tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    count4To11 += tons;
                }
                else if (tons >= 12)
                {
                    countUp12 += tons;
                }
            }

            var averageTons = (countTo3 * 200 + count4To11 * 175 + countUp12 * 120) / sum;

            Console.WriteLine("{0:F2}", averageTons);
            Console.WriteLine("{0:F2}%", countTo3 / sum * 100);
            Console.WriteLine("{0:F2}%", count4To11 / sum * 100);
            Console.WriteLine("{0:F2}%", countUp12 / sum * 100);
        }
    }
}
