using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (4 * n) + 1;

            Console.WriteLine("{0}", new string('#', width));

            var dots = 1;
            var spaces = 1;
            var hashTags = (width - 2 * dots - spaces) / 2;
            for (int i = 0; i < n; i++)
            {
                var middleSpaces = (spaces - 3) / 2;
                if (i == n / 2)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', dots), new string('#', hashTags), new string(' ', middleSpaces));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dots), new string('#', hashTags), new string(' ', spaces));
                }
                dots++;
                spaces += 2;
                hashTags -= 2;
            }

            spaces -= 2;
            var hashtagsBelow = spaces;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', hashtagsBelow));
                dots++;
                hashtagsBelow -= 2;

            }
        }
    }
}
