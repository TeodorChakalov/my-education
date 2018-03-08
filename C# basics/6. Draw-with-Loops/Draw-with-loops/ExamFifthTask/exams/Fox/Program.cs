using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n + 3;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*',i), new string('-', width - 2 - 2 * i));
            }

            var stars = n / 2;
            var middleStars = width - 4 - 2 * stars;
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', stars), new string('*', middleStars));
                stars++;
                middleStars-=2;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', width - 2 - 2 * i));
            }
        }
    }
}
