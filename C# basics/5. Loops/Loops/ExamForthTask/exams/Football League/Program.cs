using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacityStadium = double.Parse(Console.ReadLine());
            var countFans = double.Parse(Console.ReadLine());

            var countInA = 0.0;
            var countInB = 0.0;
            var countInV = 0.0;
            var countInG = 0.0;

            for (int i = 1; i <= countFans; i++)
            {
                var sector = Console.ReadLine();

                if(sector == "A")
                {
                    countInA += 1;
                }
                else if (sector == "B")
                {
                    countInB += 1;
                }
                else if (sector == "V")
                {
                    countInV += 1;
                }
                else if (sector == "G")
                {
                    countInG += 1;
                }
            }

            var percentInAsector = countInA / countFans * 100;
            var percentInBsector = countInB / countFans * 100;
            var percentInVsector = countInV / countFans * 100;
            var percentInGsector = countInG / countFans * 100;

            var percentAllFans = countFans / capacityStadium * 100;

            Console.WriteLine("{0:F2}%", percentInAsector);
            Console.WriteLine("{0:F2}%", percentInBsector);
            Console.WriteLine("{0:F2}%", percentInVsector);
            Console.WriteLine("{0:F2}%", percentInGsector);
            Console.WriteLine("{0:F2}%", percentAllFans);
        }
    }
}
