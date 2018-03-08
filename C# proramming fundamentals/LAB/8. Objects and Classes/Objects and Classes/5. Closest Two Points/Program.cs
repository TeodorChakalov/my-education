using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Closest_Two_Points
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            var allPoints = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                var currentPoint = ReadPoint();

                allPoints.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstMinPoint = null;
            Point secondMinPoint = null;

            for (int i = 0; i < numberOfPoints; i++)
            {
                for (int j = i+1; j < numberOfPoints; j++)
                {
                    var firstPoint = allPoints[i];
                    var secondPoint = allPoints[j];

                    var currentDistance = Distance(firstPoint, secondPoint);

                    if(currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstMinPoint = firstPoint;
                        secondMinPoint = secondPoint;
                    }
                }
            }
            Console.WriteLine("{0:F3}", minDistance);

            Console.WriteLine("({0}, {1})", firstMinPoint.X , firstMinPoint.Y);
            Console.WriteLine("({0}, {1})", secondMinPoint.X, secondMinPoint.Y);
        }

        static double Distance(Point firstPoint, Point secondPoint)
        {
            var distance = Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2));
            return distance;
        }

        public static Point ReadPoint()
        {
            var PointData = Console.ReadLine().Split(' ');

            var point = new Point {X = int.Parse(PointData[0]), Y = int.Parse(PointData[1]) };

            return point;
        }
    }
}