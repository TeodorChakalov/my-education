﻿using System;

namespace _7.Divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}