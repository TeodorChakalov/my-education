using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (2 * n) - 1;

            Console.WriteLine("@{0}@{0}@", new string(' ', (width - 3) / 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', (width - 5) / 2));

            var dots = 1;
            var spaces = n - 5;
            var middleDots = 1;
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.',dots), new string(' ', spaces), new string('.',middleDots));
                dots++;
                spaces -= 2;
                middleDots += 2;
            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', dots), new string('.', (width - 4 - 2 * dots)));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', dots+1), new string('*', (width - n - 3) / 2));


            Console.WriteLine("{0}", new string('*', width));
            Console.WriteLine("{0}", new string('*', width));
        }
    }
}
