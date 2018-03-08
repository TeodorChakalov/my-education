using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n + 1;

            Console.WriteLine("{0}", new string('*', width));
            Console.WriteLine(".*{0}*.", new string(' ', width - 4));

            int i = 2;
            var atSign = width - 2 * i - 2;
            for (i = 2; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.',i), new string('@', atSign));
                atSign -= 2;
            }

            Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2));

            var spaces = 0;
            for (i = n - 1; i > 1; i--)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', i), new string(' ', spaces));
                spaces++;
            }

            Console.WriteLine(".*{0}*.", new string('@', width - 4));
            Console.WriteLine("{0}", new string('*', width));
        }
    }
}
