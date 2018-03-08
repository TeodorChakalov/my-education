using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var tomato = double.Parse(Console.ReadLine());
            var boxes = int.Parse(Console.ReadLine());
            var jars = int.Parse(Console.ReadLine());

            var totalLutenitsa = tomato / 5;
            var jar = totalLutenitsa / 0.535;
            var box = jar / jars;

            if(box > boxes)
            {
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(totalLutenitsa));
                Console.WriteLine("{0} boxes left.", Math.Floor(box - boxes));
                Console.WriteLine("{0} jars left.", Math.Floor(jar - (boxes * jars)));
            }
            else
            {
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(totalLutenitsa));
                Console.WriteLine("{0} more boxes needed.", Math.Floor(boxes - box));
                Console.WriteLine("{0} more jars needed.", Math.Floor((boxes * jars) - jar));
            }
        }
    }
}
