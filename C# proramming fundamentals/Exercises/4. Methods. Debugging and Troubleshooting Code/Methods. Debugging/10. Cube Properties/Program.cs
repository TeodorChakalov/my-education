using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

           var result = GetLenght(sideOfTheCube, parameter);
            Console.WriteLine("{0:F2}", result);
        }

        static double GetLenght(double sideOfTheCube, string parameter)
        {
            double result = 0;
            switch (parameter)
            {
                case "face": result = Math.Sqrt(2 * sideOfTheCube * sideOfTheCube); break;
                case "space": result = Math.Sqrt(3 * sideOfTheCube * sideOfTheCube); break;
                case "volume": result = sideOfTheCube * sideOfTheCube * sideOfTheCube; break;
                case "area": result = 6 * sideOfTheCube * sideOfTheCube; break;
            }
            return result;
        }
    }
}