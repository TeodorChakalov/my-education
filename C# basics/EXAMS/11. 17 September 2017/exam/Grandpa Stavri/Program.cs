using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            var countDays = int.Parse(Console.ReadLine());
            var litters = 0.0;
            var everyDay = 0.0;

            for (int i = 0; i < countDays; i++)
            {
                var quantity = double.Parse(Console.ReadLine());
                var degrees = double.Parse(Console.ReadLine());

                litters += quantity;
                everyDay = everyDay + quantity * degrees;
            }

            var allDegrees = everyDay / litters;

            Console.WriteLine("Liter: {0:F2}", litters);
            Console.WriteLine("Degrees: {0:F2}", allDegrees);

            if (allDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (allDegrees >= 38 && allDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (allDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }

        }
    }
}
