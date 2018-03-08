using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            
            var a = number / 100;
            var b = (number / 10) % 10;
            var c = number % 10;
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        Console.WriteLine("{0} * {1} * {2} = {3};", i, j, k, i * j * k);
                    }
                }
            }
        }
    }
}
