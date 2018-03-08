using System;

namespace _2.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F12}", Math.PI * Math.Pow(radius, 2));
        }
    }
}