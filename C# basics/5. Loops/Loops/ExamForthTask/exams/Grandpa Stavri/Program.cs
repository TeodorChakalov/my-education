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
            var n = int.Parse(Console.ReadLine());

            var litters = 0.0;
            var everyDay = 0.0;

            for (int i = 0; i < n; i++)
            {
                var quantity = double.Parse(Console.ReadLine());
                var degree = double.Parse(Console.ReadLine());

                everyDay += quantity * degree;
                litters += quantity;
            }
            var allDegrees = everyDay / litters;

            Console.WriteLine("Liter: {0:F2}",litters);
            Console.WriteLine("Degrees: {0:F2}", allDegrees);

            if (allDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (allDegrees >= 38 && allDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
