using System;

namespace _4.Distance_between_Points
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
            var firstPointData = Console.ReadLine().Split(' ');
            var secondPointData = Console.ReadLine().Split(' ');

            var firstPoint = new Point { X = double.Parse(firstPointData[0]), Y = double.Parse(firstPointData[1]) };
            var secondPoint = new Point { X = double.Parse(secondPointData[0]), Y = double.Parse(secondPointData[1]) };

            double distance = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine("{0:F3}", distance);

            //var distanceBetweenTwoPoints = Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2));

            //Console.WriteLine("{0:F3}", distanceBetweenTwoPoints);

        }
        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var hypotenuse = Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2));
            return hypotenuse;
        }
    }
}