using System;

namespace _6.Calculate_Triangle_Area
{
    class Program
    {
        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var area = GetTriangleArea(width, height);
            Console.WriteLine(area);
        }
    }
}