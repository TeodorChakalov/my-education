﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readline
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = double.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("Area: " + area);
        }
    }
}