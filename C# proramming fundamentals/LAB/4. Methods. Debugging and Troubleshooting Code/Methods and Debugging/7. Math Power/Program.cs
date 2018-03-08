using System;

namespace _7.Math_Power
{
    class Program
    {
        static double getNumberOfThePower(double number, double power)
        {
            return Math.Pow(number, power);
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            var result = getNumberOfThePower(number, power);
            Console.WriteLine(result);
        }
    }
}