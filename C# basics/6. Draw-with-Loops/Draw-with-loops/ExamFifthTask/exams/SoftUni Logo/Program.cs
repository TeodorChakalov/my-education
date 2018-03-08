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

            var hashTag = 1;
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (12 * n - 5 - hashTag) / 2), new string('#',hashTag));
                hashTag += 6;
            }

            var dots = 2;
            var endDots = 3;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}",new string('.',dots), new string('#',12 * n - 6 - dots - endDots), new string('.', endDots));
                dots += 3;
                endDots += 3;
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}",new string('.',dots), new string('#', 12 * n - 6 - dots - endDots), new string('.', endDots));
            }

            Console.WriteLine("@{0}{1}{2}", new string('.', dots), new string('#', 12 * n - 6 - dots - endDots),new string('.', endDots));
        }
    }
}