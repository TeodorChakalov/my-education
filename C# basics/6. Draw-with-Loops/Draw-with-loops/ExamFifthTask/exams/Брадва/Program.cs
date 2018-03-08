using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-',3 * n), new string('-', i), new string('-',2 * n - i - 2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', 3 * n), new string('-',n - 1), new string('-', 2 * n - n + 1 - 2));
            }

            var firstDashes = 3 * n;
            var middleDashes = n - 1;
            var endDashes = 5 * n - firstDashes - middleDashes - 2;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', firstDashes), new string('-', middleDashes), new string('-', endDashes));
                firstDashes--;
                middleDashes += 2;
                endDashes--;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', firstDashes), new string('*', middleDashes), new string('-', endDashes));
        }
    }
}
