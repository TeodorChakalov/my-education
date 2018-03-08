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
            var countTomato = double.Parse(Console.ReadLine());
            var boxes = int.Parse(Console.ReadLine());
            var jars = int.Parse(Console.ReadLine());

            var totalLutenitsa = countTomato / 5;
            var totalBoxes = totalLutenitsa / 0.535;
            var totalJars = totalBoxes / jars;

            if(totalJars >= boxes)
            {
                Console.WriteLine("Total lutenica: {0} kilograms.",Math.Floor(totalLutenitsa));
                Console.WriteLine("{0} boxes left.", Math.Floor(totalJars - boxes));
                Console.WriteLine("{0} jars left.", Math.Floor(totalBoxes - (boxes * jars)));
            }
            else
            {
                Console.WriteLine("Total lutenica: {0} kilograms.",Math.Floor(totalLutenitsa));
                Console.WriteLine("{0} more boxes needed.", Math.Floor(boxes - totalJars));
                Console.WriteLine("{0} more jars needed.", Math.Floor(boxes * jars - totalBoxes));
            }
        }
    }
}