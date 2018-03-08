using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', (4 * n + 1 - 3) / 2));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', (4 * n + 1 - 3) / 2));

            Console.Write(new string('.', (4 * n + 1 - 3) / 2));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', (4 * n + 1 - 3) / 2));

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', (4 * n + 1 - 3) / 2 - i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.WriteLine(new string('.', (4 * n + 1 - 3) / 2 - i));
            }

            Console.WriteLine(new string('*', 4 * n + 1));

            for (int i = 0; i < (4 * n + 1) / 2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
