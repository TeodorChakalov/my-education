using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n + 6;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', n));
            }

            Console.WriteLine("{0}", new string('=', width - 1));

            for (int i = 0; i < n-2; i++)
            {
                if(i == n / 2 - 1)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~',(width - n - 6) / 2), new string(' ', n - 1));
                }
                else
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', width - n - 2), new string(' ', n - 1));
                }
            }

            Console.WriteLine("{0}", new string('=', width - 1));

            var atSign = 2 * n + 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string(' ', i), new string('@', atSign));
                atSign -= 2;
            }

            Console.WriteLine("{0}", new string('=', width - n));
        }
    }
}
