using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сбор_или_Произведение
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int flag = 0;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if ((a < b && b < c) && (a + b + c == number))
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", a,b,c, number);
                            flag = 1;
                        }
                        else if ((a > b && b > c) && (a * b * c == number))
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, number);
                            flag = 1;
                        }
                    }
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}