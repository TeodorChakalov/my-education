using System;

namespace _9.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = GetLine(x1, y1, x2, y2);
            double secondLine = GetLine(x3, y3, x4, y4);

            if(firstLine >= secondLine)
            {
                PrintPointFromTheLineIsClosestToCentre(x1, y1, x2, y2);
            }
            else
            {
                PrintPointFromTheLineIsClosestToCentre(x3, y3, x4, y4);
            }
        }

        static double GetLine(double x1, double y1, double x2, double y2)
        {
            double line = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return line;
        }

        static void PrintPointFromTheLineIsClosestToCentre(double x1, double y1, double x2, double y2)
        {
            double distanceFirstPointToCentre = Math.Sqrt(Math.Pow(x1 + y1, 2));
            double distanceSecondPointToCentre = Math.Sqrt(Math.Pow(x2 + y2, 2));

            if(distanceFirstPointToCentre <= distanceSecondPointToCentre)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
        }
    }
}