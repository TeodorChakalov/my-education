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

            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine(".*{0}*.", new string(' ', 2 * n - 3));

            int i = 0;
            var atSign = 2 * n + 1 - 2 - 2 * i - 2 * 2;
            for (i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i + 2), new string('@', atSign));
                atSign -= 2;
            }
            Console.WriteLine("{0}*{0}", new string('.', 2 * n / 2));

            for (i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', (2 * n + 1 - 3 - 2 * i)/ 2), new string(' ', i));
            }

            Console.WriteLine(".*{0}*.", new string('@', 2 * n - 3));
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
