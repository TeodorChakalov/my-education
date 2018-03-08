using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if(number % a == 0 && number % b == 0 && number % c == 0 && number % d == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                            }
                        }
                    }
                }
            }
        }
    }
}
