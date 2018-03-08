using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = n * 2 - 1;
            var height = n / 2 + 4;
            var LeftRightdots = 1;
            var space = n - 5;
            var midDots = 1;


            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));

            for (int i = 1; i <= height - 6; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', LeftRightdots), new string(' ', space), new string('.', midDots));
                LeftRightdots++;
                space -= 2;
                midDots += 2;
            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', n / 2 - 1), new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', (width - 3 - n) / 2));

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0}", new string('*', width));
            }
        }
    }
}