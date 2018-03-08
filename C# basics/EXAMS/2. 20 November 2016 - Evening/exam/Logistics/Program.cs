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
            var countLoad = int.Parse(Console.ReadLine());
            var allLoads = 0;
            var till3 = 0.0;
            var between4And11 = 0.0;
            var over12 = 0.0;

            for (int i = 0; i < countLoad; i++)
            {
                var weightLoad = int.Parse(Console.ReadLine());
                allLoads += weightLoad;

                if(weightLoad<=3)
                {
                    till3+=weightLoad;
                }
                else if(weightLoad>=4 && weightLoad <= 11)
                {
                    between4And11+=weightLoad;
                }
                else if (weightLoad >= 12)
                {
                    over12+= weightLoad;
                }
            }
            var averagePrice = (till3 * 200 + between4And11 * 175 + over12 * 120) / allLoads;

            Console.WriteLine("{0:F2}", averagePrice);
            Console.WriteLine("{0:F2}%", till3 / allLoads * 100);
            Console.WriteLine("{0:F2}%", between4And11 / allLoads * 100);
            Console.WriteLine("{0:F2}%", over12 / allLoads * 100);
        }
    }
}
