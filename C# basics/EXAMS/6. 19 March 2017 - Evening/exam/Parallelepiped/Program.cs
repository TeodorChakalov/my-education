using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n + 1;

            Console.WriteLine("+{0}+{1}", new string('~', n-2), new string('.',width - n));

            for (int i = 0; i <= 2 * n; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i), new string('~', n-2), new string('.', width - n - 1 - i));
            }

            for (int i = 0; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', width - n - 1 - i), new string('~', n-2));
            }

            Console.WriteLine("{0}+{1}+", new string('.', width - n), new string('~', n - 2));

        }
    }
}
