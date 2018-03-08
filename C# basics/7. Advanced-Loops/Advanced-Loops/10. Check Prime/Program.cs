﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            var prime = true;

            for (int i = 2; i <= n; i++)
            {
                if(n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");

            //string result = isPrime ? "Prime" : "Not Prime";
            //Console.WriteLine(result);
        }
    }
}
