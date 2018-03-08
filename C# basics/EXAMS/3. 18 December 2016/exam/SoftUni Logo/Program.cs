using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 12 * n - 5;
            var dies = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - dies) / 2), new string('#',dies));
                dies += 6;
            }

            var dots = 2;
            var dots1 = 3;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.',dots), new string('#',width - 1 - dots - dots1), new string('.',dots1));
                dots += 3;
                dots1 += 3;
            }

            for (int i = 0; i < n; i++)
            {
                if(i == n-1)
                {
                    Console.WriteLine("@{0}{1}{2}", new string('.', dots), new string('#', width - 1 - dots - dots1), new string('.', dots1));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', dots), new string('#', width - 1 - dots - dots1), new string('.', dots1));
                }
            }

        }
    }
}
