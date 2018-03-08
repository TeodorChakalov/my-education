using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.Write("Combination N:{0} ", counter);
                        Console.WriteLine("({0} + {1} = {2})", i,j,magicNumber);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
        }
    }
}
