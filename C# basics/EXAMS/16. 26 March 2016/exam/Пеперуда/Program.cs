using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n - 1;

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
            }

            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
            }
        }
    }
}
