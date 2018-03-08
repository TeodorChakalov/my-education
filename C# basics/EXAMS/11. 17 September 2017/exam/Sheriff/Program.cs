using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n;

            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (width - 3) / 2));

            int i = n / 2;
            var x = (width - 2 * i - 1) / 2;
            for (i = n / 2; i > 0; i--)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.',i), new string('x',x));
                x++;
            }

            Console.WriteLine("{0}|{0}", new string('x', (width - 1) / 2));

            x--;
            for (i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i), new string('x', x));
                x--;
            }


            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));

            x++;
            for (i = n / 2; i > 0; i--)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i), new string('x', x));
                x++;
            }

            Console.WriteLine("{0}|{0}", new string('x', (width - 1) / 2));

            x--;
            for (i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i), new string('x', x));
                x--;
            }


            Console.WriteLine("{0}x|x{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));
        }
    }
}