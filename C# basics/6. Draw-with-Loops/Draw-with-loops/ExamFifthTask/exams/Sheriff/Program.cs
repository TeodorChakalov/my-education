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

            Console.Write(new string('.', (3 * n - 1) / 2));
            Console.Write("x");
            Console.WriteLine(new string('.', (3 * n - 1) / 2));

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            var spaces = n / 2;
            var x = n;

            for (int i = 0; i <= n / 2; i++)
            {
                Console.Write(new string('.', spaces));
                Console.Write(new string('x', x));
                Console.Write("|");
                Console.Write(new string('x', x));
                Console.WriteLine(new string('.', spaces));

                spaces--;
                x++;
            }

            spaces+=2;
            x -= 2;

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write(new string('.', spaces));
                Console.Write(new string('x', x));
                Console.Write("|");
                Console.Write(new string('x', x));
                Console.WriteLine(new string('.', spaces));

                spaces++;
                x--;
            }

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            spaces -= 1;
            x += 1;

            for (int i = 0; i <= n / 2; i++)
            {
                Console.Write(new string('.', spaces));
                Console.Write(new string('x', x));
                Console.Write("|");
                Console.Write(new string('x', x));
                Console.WriteLine(new string('.', spaces));

                spaces--;
                x++;
            }

            spaces += 2;
            x -= 2;

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write(new string('.', spaces));
                Console.Write(new string('x', x));
                Console.Write("|");
                Console.Write(new string('x', x));
                Console.WriteLine(new string('.', spaces));

                spaces++;
                x--;
            }

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            Console.Write(new string('.', (3 * n - 3) / 2));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', (3 * n - 3) / 2));

            Console.Write(new string('.', (3 * n - 1) / 2));
            Console.Write("x");
            Console.WriteLine(new string('.', (3 * n - 1) / 2));
        }
    }
}