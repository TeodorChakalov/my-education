using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', n + i));
                Console.Write(new string('#', 3 * n - 2 * i));
                Console.WriteLine(new string('.', n + i));
            }

            for (int i = 0; i <= n / 2; i++)
            {
                var pointsOut = 3 * n / 2 + i;
                Console.Write(new string('.', pointsOut));
                Console.Write("#");
                Console.Write(new string('.', (5 * n - 2 * pointsOut - 2)));
                Console.Write("#");
                Console.WriteLine(new string('.', (pointsOut)));
            }


            Console.Write(new string('.', 4 * n / 2));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', 4 * n / 2));


            for (int i = 0; i < n + 2; i++)
            {
                if(i == n / 2)
                {
                    Console.Write(new string('.', (5 * n - 10) / 2));
                    Console.Write("D^A^N^C^E^");
                    Console.WriteLine(new string('.', (5 * n - 10) / 2));
                }
                else
                {
                    Console.Write(new string('.', (5 * n - (n + 4)) / 2));
                    Console.Write(new string('#', n + 4));
                    Console.WriteLine(new string('.', (5 * n - (n + 4)) / 2));
                }
            }
        }
    }
}
