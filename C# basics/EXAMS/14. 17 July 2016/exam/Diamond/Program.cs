using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

            for (int i = n-1; i >= 1; i--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', width - 2 - 2 * i));
            }

            Console.WriteLine("{0}", new string('*', width));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', width - 2 - 2 * i));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
        }
    }
}
