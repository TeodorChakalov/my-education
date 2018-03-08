using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //int j = 0;

            //for (int i = 0;i < 10; i++)
            //{
            //    for (j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*',10));
            }
        }
    }
}
