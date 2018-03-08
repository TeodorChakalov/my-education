using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n + 3;

            for (int i = 0; i <= n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.',i), new string('.',n - i));
            }

            Console.WriteLine("{0}*****{0}", new string('.', (width - 5) / 2));
            Console.WriteLine("{0}", new string('*', width));
            Console.WriteLine("{0}*****{0}", new string('.', (width - 5) / 2));

            var dots = n - 2;
            for (int i = 0; i <= n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots), new string('.', n - dots));
                dots--;
            }
        }
    }
}
