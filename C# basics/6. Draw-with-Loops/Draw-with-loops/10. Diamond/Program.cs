using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                var firstSpaces = (n - 2) / 2;
                var middleSpaces = 0;

                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', firstSpaces), new string('-', middleSpaces));
                        firstSpaces--;
                        middleSpaces += 2;
                    }
                }

                Console.WriteLine("*{0}*", new string('-', n - 2));

                firstSpaces++;
                middleSpaces -= 2;
                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', firstSpaces), new string('-', middleSpaces));
                    firstSpaces++;
                    middleSpaces -= 2;
                }
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine("*");
                    return;
                }
                else if (n == 3)
                {
                    Console.WriteLine("-*-");
                    Console.WriteLine("*-*");
                    Console.WriteLine("-*-");
                    return;
                }
                Console.WriteLine("{0}*{0}", new string('-', n / 2));

                var firstSpaces = (n - 2) / 2;
                var middleSpaces = 1;

                for (int i = 0; i <= n / 2 - 2; i++)
                {
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', firstSpaces), new string('-', middleSpaces));
                        firstSpaces--;
                        middleSpaces += 2;
                    }
                }

                Console.WriteLine("*{0}*", new string('-', n - 2));

                firstSpaces++;
                middleSpaces -= 2;
                for (int i = 0; i <= n / 2 - 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', firstSpaces), new string('-', middleSpaces));
                    firstSpaces++;
                    middleSpaces -= 2;
                }

                Console.WriteLine("{0}*{0}", new string('-', n / 2));
            }
        }
    }
}
