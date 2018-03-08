using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.',n + 1), new string('_', 2 * n + 1));

            var dots = n;
            var middleSpaces = 2 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', dots), new string('_', middleSpaces));
                middleSpaces += 2;
                dots--;
            }

            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', (4 * n + 3 - 9) / 2));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', i), new string('_', middleSpaces));
                middleSpaces -= 2;
            }
        }
    }
}
