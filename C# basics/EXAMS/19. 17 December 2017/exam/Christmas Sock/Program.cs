using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Sock
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("|{0}|", new string('-', 2 * n));
            Console.WriteLine("|{0}|", new string('*', 2 * n));
            Console.WriteLine("|{0}|", new string('-', 2 * n));

            var dashes = n - 1;
            var tilda = 2;
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine("|{0}{1}{0}|", new string('-', dashes), new string('~', tilda));
                dashes--;
                tilda += 2;
            }

            tilda -= 4;
            dashes += 2;
            for (int i = 2; i < n; i++)
            {
                Console.WriteLine("|{0}{1}{0}|", new string('-', dashes), new string('~', tilda));
                dashes++;
                tilda -= 2;
            }

            for (int i = 0; i <= n + 2; i++)
            {
                if(i == n / 2)
                {
                     Console.WriteLine("{0}\\{1}MERRY{1}\\", new string('-', i), new string('.', (2 * n - 4) / 2));
                }
                else if(i == n / 2 + 2)
                {
                    Console.WriteLine("{0}\\{1}X-MAS{1}\\", new string('-', i), new string('.', (2 * n - 4) / 2));
                }
                else if(i == n + 2)
                {
                    Console.WriteLine("{0}\\{1})", new string('-', i), new string('_', 2 * n + 1));
                }
                else
                {
                    Console.WriteLine("{0}\\{1}\\", new string('-', i), new string('.', 2 * n + 1));
                }
            }
        }
    }
}
