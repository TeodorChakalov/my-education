using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 0;

            if (n % 2 == 0)
            {
                stars = 2;
                for (int i = 0; i < n / 2 + 1; i++)
                {
                    Console.Write(new string('-', (n - stars) / 2));
                    Console.Write(new string('*', stars));
                    Console.WriteLine(new string('-', (n - stars) / 2));
                    stars+=2;
                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }
            else if (n % 2 != 0)
            {
                stars = 1;
                for (int i = 0; i < n / 2 + 1; i++)
                {
                    Console.Write(new string('-', (n - stars) / 2));
                    Console.Write(new string('*', stars));
                    Console.WriteLine(new string('-', (n - stars) / 2));
                    stars += 2;
                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }
        }
    }
}
