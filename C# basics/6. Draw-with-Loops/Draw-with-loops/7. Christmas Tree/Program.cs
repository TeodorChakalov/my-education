using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= n; i++)
            //{
            //    var stars = new string('*', i);
            //    var spaces = new string(' ', n - i);

            //    Console.Write(spaces);
            //    Console.Write(stars);
            //    Console.Write(" | ");
            //    Console.Write(stars);
            //    Console.Write(spaces);

            //    Console.WriteLine();
            //}

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}{1} | {1}{0}", new string(' ', n - i), new string('*', i));
            }
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int countOfWhiteSpaces = n;
            int rows = n + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < countOfWhiteSpaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < countOfWhiteSpaces; j++)
                {
                    Console.Write(" ");
                }
                countOfWhiteSpaces--;
                Console.WriteLine();
            }

        }
    }
}
*/