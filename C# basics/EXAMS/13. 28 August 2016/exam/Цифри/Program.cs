using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;

            for (int i = 1; i <= a + b; i++)
            {
                for (int j = 1; j <= a + c; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - a;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - b;
                    }
                    else
                    {
                        n = n + c;
                    }
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }
    }
}
