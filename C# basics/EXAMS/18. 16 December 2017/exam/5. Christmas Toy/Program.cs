using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Christmas_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;

            Console.WriteLine("{0}{1}{0}", new string('-', (width - n)/2), new string('*', n));

            var stars = 1;
            var ampersand = n + 2;
            var dashes = (width - ampersand - 2 * stars) / 2;
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', dashes), new string('*', stars), new string('&', ampersand));
                stars++;
                ampersand += 2;
                dashes -= 2;
            }

            var dashesBelow = n - 1;
            var tilda = width - 2 * dashesBelow - 4;
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}**{1}**{0}", new string('-', dashesBelow), new string('~', tilda));
                dashesBelow--;
                tilda += 2;
            }

            Console.WriteLine("{0}*{1}*{0}", new string('-', n/2), new string('|', width - 2 * (n / 2) - 2));

            dashesBelow++;
            tilda -= 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}**{1}**{0}", new string('-', dashesBelow), new string('~', tilda));
                dashesBelow++;
                tilda -= 2;
            }

            stars--;
            ampersand -= 2;
            dashes += 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', dashes), new string('*', stars), new string('&', ampersand));
                stars--;
                ampersand -= 2;
                dashes += 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', (width - n) / 2), new string('*', n));
        }
    }
}
