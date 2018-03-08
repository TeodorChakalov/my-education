using System;
using System.Linq;

namespace _3.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            //        double[] command = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //        Circle circle1 = new Circle();
            //        circle1.Center = new Point();
            //        circle1.Center.X = command[0];
            //        circle1.Center.Y = command[1];
            //        circle1.Radius = command[2];

            //        command = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //        Circle circle2 = new Circle();
            //        circle2.Center = new Point();
            //        circle2.Center.X = command[0];
            //        circle2.Center.Y = command[1];
            //        circle2.Radius = command[2];

            //        if (circle1.IsIntersected(circle2))
            //        {
            //            Console.WriteLine("Yes");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No");
            //        }
            //    }
            //}
            //class Point
            //{
            //    public double X { get; set; }
            //    public double Y { get; set; }
            //}
            //class Circle
            //{
            //    public Point Center { get; set; }
            //    public double Radius { get; set; }

            //    public bool IsIntersected(Circle circle)
            //    {
            //        double distance = Math.Sqrt(Math.Abs(circle.Center.X - Center.X) * (circle.Center.X - Center.X) + Math.Abs(circle.Center.Y - Center.Y) * (circle.Center.Y - Center.Y));
            //        if(distance <= circle.Radius + Radius)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }

            int[] FirstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] SecondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var circle1 = new Circle
            {
                Radius = FirstArr[2],
                Center = new Point
                {
                    X = FirstArr[0],
                    Y = FirstArr[1]
                }
            };
            var circle2 = new Circle
            {
                Radius = SecondArr[2],
                Center = new Point
                {
                    X = SecondArr[0],
                    Y = SecondArr[1]
                }
            };

            var result = Intersect(circle1, circle2);

            if (result) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }

        static bool Intersect(Circle c1, Circle c2)
        {
            double distance = Math.Sqrt(Math.Abs(c1.Center.X - c2.Center.X) * Math.Abs((c1.Center.X - c2.Center.X)) + Math.Abs(c1.Center.Y - c2.Center.Y) * Math.Abs((c1.Center.Y - c2.Center.Y)));

            if (distance > (c1.Radius + c2.Radius))
            {
                return false;
            }

            return true;

        }
    }

    class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}

