﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

           /*
            var n = int.Parse(Console.ReadLine());
            var fact = 1;

            do
            {
                fact = fact * n;
                n--;
            } while (n > 1)
            Console.WriteLine(fact);
            */
        }
    }
}
