﻿using System;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var perimeter = 2 * width + 2 * height;
            var area = width * height;
            var diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow((height), 2));

            Console.WriteLine("{0}", perimeter);
            Console.WriteLine("{0}", area);
            Console.WriteLine("{0}", diagonal);
        }
    }
}