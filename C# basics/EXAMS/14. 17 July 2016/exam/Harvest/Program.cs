using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyard = int.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var necessaryVine = int.Parse(Console.ReadLine());
            var countEmployee = int.Parse(Console.ReadLine());

            var allGrapes = vineyard * grape;
            var vine = 0.4 * allGrapes / 2.5;

            if(vine >= necessaryVine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(vine - necessaryVine), Math.Ceiling((vine - necessaryVine) / countEmployee));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(necessaryVine - vine));
            }
        }
    }
}
