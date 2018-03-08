using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n;
            var dots = (width - 2) / 2;
            var spaces = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.', dots), new string(' ',spaces));

                dots--;
                spaces += 2;
            }

            dots++;
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', width - 2 * dots));

            for(int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', dots), new string('\\',width - 2 - 2 * dots));
            }

            var stars = width - 2 - 2 * dots;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.',dots), new string('*', stars));

                dots--;
                stars += 2;
            }
        }
    }
}
