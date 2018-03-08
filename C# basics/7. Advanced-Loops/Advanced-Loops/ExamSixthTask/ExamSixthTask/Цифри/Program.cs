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
            var number = int.Parse(Console.ReadLine());
            int a = number / 100;
            int b = (number / 10) % 10;
            int c = number % 10;

            for(int i = 1; i <= (a + b); i++)
            {
                for (int j = 1; j <=(a + c); j++)
                {
                    if (number % 5 == 0) number -= a;
                    else if (number % 3 == 0) number -= b;
                    else number += c;
                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
            }
        }
    }
}
