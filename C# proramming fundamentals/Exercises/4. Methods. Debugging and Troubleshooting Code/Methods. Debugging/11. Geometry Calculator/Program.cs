using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if(figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double result = GetTriangleArea(side, height);
                Console.WriteLine("{0:F2}", result);
            }
            else if(figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double result = getSquareArea(side);
                Console.WriteLine("{0:F2}", result);
            }
            else if(figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double result = getRectangleArea(width, height);
                Console.WriteLine("{0:F2}", result);
            }
            else if(figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double result = getCirleArea(radius);
                Console.WriteLine("{0:F2}", result);
            }
        }

        static double GetTriangleArea(double side, double height)
        {
            double result = side * height / 2;
            return result;
        }
        static double getSquareArea(double side)
        {
            double result = side * side;
            return result;
        }
        static double getRectangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }
        static double getCirleArea(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }
    }
}