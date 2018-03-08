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

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', (2 * n / 2 - i)));
                Console.Write("*");
                Console.Write(new string('.', 2 * n / 2 - i));
                Console.Write("*");
                Console.WriteLine(new string('.', i));
            }


            Console.Write(new string('.', (2 * n + 3 - 5) / 2));
            Console.Write("*****");
            Console.WriteLine(new string('.', (2 * n + 3 - 5) / 2));

            Console.WriteLine(new string('*', 2 * n + 3));

            Console.Write(new string('.', (2 * n + 3 - 5) / 2));
            Console.Write("*****");
            Console.WriteLine(new string('.', (2 * n + 3 - 5) / 2));


            for (int i = n - 2; i >= 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', 2 * n / 2 - i));
                Console.Write("*");
                Console.Write(new string('.', 2 * n / 2 - i));
                Console.Write("*");
                Console.WriteLine(new string('.', i));
            }
        }
    }
}
