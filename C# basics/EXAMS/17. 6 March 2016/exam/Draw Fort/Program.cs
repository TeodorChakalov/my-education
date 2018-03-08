using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 2 * n;
            var chovs = n / 2;
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', chovs), new string('_', width - 2 * chovs - 4));

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', width - 2));
            }

            var underscore = width - 2 * chovs - 4;
            Console.WriteLine("|{0}{1}{0}|", new string(' ', (width - underscore - 2) / 2), new string('_', underscore));

            var spaces = underscore;
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', (width - spaces - 3) / 2), new string(' ', spaces));
        }
    }
}
