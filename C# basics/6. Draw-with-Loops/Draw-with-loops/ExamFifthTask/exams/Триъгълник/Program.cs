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

            Console.WriteLine(new string('#', 4 * n + 1));

            var width = 4 * n + 1;

            for (int i = 1; i <= n; i++)
            {  
                if(i == n / 2 + 1)
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('#', width / 2 - i - (i - 1)));
                    Console.Write(new string(' ', (2 * i - 1 - 3) / 2));
                    Console.Write("(@)");
                    Console.Write(new string(' ', (2 * i - 1 - 3) / 2));
                    Console.Write(new string('#', width / 2 - i - (i - 1)));
                    Console.WriteLine(new string('.', i));
                }
                else
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('#', width / 2 - i - (i - 1)));
                    Console.Write(new string(' ', 2 * i - 1));
                    Console.Write(new string('#', width / 2 - i - (i - 1)));
                    Console.WriteLine(new string('.', i));
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n + 1 + i));
                Console.Write(new string('#', (4 * n + 1) - 2 * (n + 1 + i)));
                Console.WriteLine(new string('.', n + 1 + i));
            }
        }
    }
}
